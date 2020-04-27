using System;
using System.Collections.Generic;
using System.Text;
using TestCase.Domain.Models;

namespace TestCase.Domain.Extensions
{
    public static class TestCaseExtensions
    {
        public static bool IsRunning(this TestCaseRun testCaseRun)
        {
            return testCaseRun.Status == Enums.ETestCaseStatus.InProgress;
        }
    }
}
