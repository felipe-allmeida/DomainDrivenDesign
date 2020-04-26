using System;
using System.Collections.Generic;
using System.Text;

namespace TestCase.Shared.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        protected abstract void Validate();
    }
}
