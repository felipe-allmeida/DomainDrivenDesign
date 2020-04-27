using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestCase.Domain.Enums;
using TestCase.Domain.Extensions;
using TestCase.Shared.Exceptions;
using TestCase.Shared.Interfaces;
using TestCase.Shared.Models;
using TestCase.Shared.Utils;

namespace TestCase.Domain.Models
{
    public class TestCase : Entity, IAggregateRoot
    {
        private List<TestCaseRun> _runs;

        public TestCase(string title)
        {
            Title = title;

            Validate();
        }

        public string Title { get; private set; }

        public IReadOnlyCollection<TestCaseRun> Runs { get { return _runs.ToArray(); } }

        public void Execute(TestCaseRun run)
        {
            if (IsTestCaseRunning())
            {
                throw new DomainException($"The TestCase {Title} is already running.");
            }

            run.Enqueue();

            _runs.Add(run);
        }        
        
        public void Stop()
        {
            var run = GetLatestRun();

            if (run != null)
            {
                throw new DomainException($"The TestCase {Title} has never been executed.");
            }

            run.Stop();
        }

        public ETestCaseStatus GetStatus()
        {
            if (_runs.Count == 0)
                return ETestCaseStatus.Active;

            return _runs.Min(x => x.Status);
        }

        private bool IsTestCaseRunning()
        {
            return _runs.Any(x => x.IsRunning());
        }

        private TestCaseRun GetLatestRun()
        {
            return _runs.OrderByDescending(x => x.StartDate).FirstOrDefault();
        }

        protected override void Validate()
        {
            EntityConcerns.IsEmpty(Title, "Title cannot be null or empty.");
        }
    }
}
