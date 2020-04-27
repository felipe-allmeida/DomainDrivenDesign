using System;
using System.Collections.Generic;
using System.Text;

namespace TestCase.Domain.Enums
{
    public enum ETestCaseStatus
    {
        Active = 0,
        Queued = 1,
        InProgress = 2,
        Stoped = 3,
        Failed = 4,
        Passed = 5
    }
}
