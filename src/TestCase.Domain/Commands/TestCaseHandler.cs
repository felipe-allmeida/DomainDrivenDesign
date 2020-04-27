using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestCase.Domain.Commands
{
    public class TestCaseHandler :
        IRequestHandler<CreateTestCaseCommand, bool>,
        IRequestHandler<ExecuteTestCaseCommand, bool>,
        IRequestHandler<StopTestCaseCommand, bool>,
    {
        public Task<bool> Handle(CreateTestCaseCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Handle(ExecuteTestCaseCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Handle(StopTestCaseCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
