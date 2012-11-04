namespace OA.Framework.Common.Commands
{
    public interface ICommandValidatorFactory
    {
        ICommandValidator<TCommand> GetInstance<TCommand>() where TCommand : class;
    }
}