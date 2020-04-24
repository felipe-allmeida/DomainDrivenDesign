using System;
using System.Collections.Generic;
using System.Text;
using TestCase.Domain.Enums;
using TestCase.Shared.Models;

namespace TestCase.Domain.Models
{
    public class TestCase : Entity
    {
        public string Title { get; private set; }

        public void AddRun(TestCaseRun run)
        {

        }
    }
}
