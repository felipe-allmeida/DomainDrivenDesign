using System;
using TestCase.Domain.Enums;
using TestCase.Shared.Exceptions;
using TestCase.Shared.Models;
using TestCase.Shared.Utils;

namespace TestCase.Domain.Models
{
    public class TestCaseRun : Entity
    {
        public TestCaseRun(string owner, ETestCaseStatus status)
        {
            Owner = owner;
            Status = status;

            StartDate = DateTime.UtcNow;
        }

        public string Owner { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public ETestCaseStatus Status { get; private set; }

        public void SetQueued()
        {
            ChangeStatus(ETestCaseStatus.Queued);
        }

        public void SetInProgress()
        {
            ChangeStatus(ETestCaseStatus.InProgress);
        }

        public void SetFinished()
        {
            ChangeStatus(ETestCaseStatus.Finished);
            EndDate = DateTime.UtcNow;
        }

        private void ChangeStatus(ETestCaseStatus newStatus)
        {
            if (newStatus <= Status)
            {
                throw new DomainException($"Error trying to change {Status} to {newStatus}. Not possible to update Status to a previous state.");
            }

            Status = newStatus;
        }

        protected override void Validate()
        {
            EntityConcerns.IsEmpty(Owner, "The TestCaseRun Owner cannot be null or empty");
        }
    }
}
