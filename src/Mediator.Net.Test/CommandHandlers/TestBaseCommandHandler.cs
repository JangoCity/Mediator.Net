﻿using System;
using System.Threading.Tasks;
using Mediator.Net.Context;
using Mediator.Net.Contracts;
using Mediator.Net.Test.Messages;
using Mediator.Net.Test.TestUtils;

namespace Mediator.Net.Test.CommandHandlers
{
    class TestBaseCommandHandler : ICommandHandler<TestBaseCommand>
    {
        
        public Task Handle(ReceiveContext<TestBaseCommand> context)
        {
            Console.WriteLine(context.Message.Id);
            RubishBox.Rublish.Add(nameof(TestBaseCommandHandler));
            return Task.FromResult(0);
        }
    }
}
