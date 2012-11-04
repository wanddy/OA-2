namespace OA.BootStrapping.Common.Implementations.Framework
{
    using System;

    using OA.Framework.Common.Commands;

    public class BootStrappedCommandHandlerFactory : ICommandHandlerFactory
    {
        public ICommandHandler<TCommand> GetHandlerFor<TCommand>() where TCommand : class
        {
            var commandHandler = BootStrapper.GetInstance<ICommandHandler<TCommand>>();
            if (commandHandler == null)
            {
                throw new InvalidCommandException("Command handler does not exist.");
            }

            return commandHandler;
        }
    }
}