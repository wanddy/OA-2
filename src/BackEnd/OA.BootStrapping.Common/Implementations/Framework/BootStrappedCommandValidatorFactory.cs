namespace OA.BootStrapping.Common.Implementations.Framework
{
    using OA.Framework.Common.Commands;

    public class BootStrappedCommandValidatorFactory : ICommandValidatorFactory
    {
        public ICommandValidator<TCommand> GetInstance<TCommand>() where TCommand : class
        {
            var commandValidatorHandler = BootStrapper.GetInstance<ICommandValidator<TCommand>>();
            if (commandValidatorHandler == null)
            {
                throw new InvalidCommandException("Command validator does not exist.");
            }

            return commandValidatorHandler;
        }
    }
}