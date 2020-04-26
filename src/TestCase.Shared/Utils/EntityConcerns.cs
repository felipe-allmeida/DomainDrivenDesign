using System;
using System.Collections.Generic;
using System.Text;
using TestCase.Shared.Exceptions;

namespace TestCase.Shared.Utils
{
    public static class EntityConcerns
    {
        public static void IsEmpty(string value, string message)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new DomainException(message);
            }
        }
    }
}
