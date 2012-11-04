namespace OA.Framework.Common.Commands
{
    public abstract class CommandHandlerDecoratorBase<TCommand> : ICommandHandler<TCommand>
        where TCommand : class
    {
        protected CommandHandlerDecoratorBase(ICommandHandler<TCommand> commandHandler)
        {
            this.DecoratedCommandHandler = commandHandler;
        }

        protected ICommandHandler<TCommand> DecoratedCommandHandler { get; private set; }

        public abstract void Execute(TCommand command);
    }
}