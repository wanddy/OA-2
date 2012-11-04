namespace OA.Framework.Common.Commands
{
    public class ValidatorCommandHandlerDecorator<TCommand> : CommandHandlerDecoratorBase<TCommand>
        where TCommand : class
    {
        public ValidatorCommandHandlerDecorator(ICommandHandler<TCommand> commandHandler)
            : base(commandHandler)
        {
        }

        public override void Execute(TCommand command)
        {
            CommandValidator.ThrowExceptionIfInvalid(command);
            this.DecoratedCommandHandler.Execute(command);
        }
    }
}