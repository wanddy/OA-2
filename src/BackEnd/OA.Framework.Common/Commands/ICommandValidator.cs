namespace OA.Framework.Common.Commands
{
    public interface ICommandValidator<TCommand>
        where TCommand : class
    {
        void ThrowExceptionIfInvalid(TCommand command);
    }
}