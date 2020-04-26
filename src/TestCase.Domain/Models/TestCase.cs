using System;
using System.Collections.Generic;
using System.Text;
using TestCase.Domain.Enums;
using TestCase.Shared.Interfaces;
using TestCase.Shared.Models;

namespace TestCase.Domain.Models
{
    public class TestCase : Entity, IAggregateRoot
    {
        private List<TestCaseRun> _runs;
        public string Title { get; private set; }

        public IReadOnlyCollection<TestCaseRun> Runs { get { return _runs.ToArray(); } }

        public void AddRun(TestCaseRun run)
        {
            _runs.Add(run);
        }        

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
