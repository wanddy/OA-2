namespace OA.Framework.Common.Commands
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<TCommand> GetHandlerFor<TCommand>() where TCommand : class;
    }
}