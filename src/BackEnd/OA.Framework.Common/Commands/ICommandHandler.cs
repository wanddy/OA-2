namespace OA.Framework.Common.Commands
{
    public interface ICommandHandler<TCommand> where TCommand : class
    {
        void Execute(TCommand command);
    }
}