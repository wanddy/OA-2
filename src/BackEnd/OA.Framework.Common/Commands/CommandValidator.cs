namespace OA.Framework.Common.Commands
{
    public static class CommandValidator
    {
        private static ICommandValidatorFactory commandValidatorFactory;

        public static void InitializeCommandValidatorFactory(ICommandValidatorFactory factory)
        {
            commandValidatorFactory = factory;
        }

        public static void ThrowExceptionIfInvalid<TCommand>(TCommand command) where TCommand : class
        {
            if (!HasCommandAttributeDefined(command))
            {
                throw new InvalidCommandException("CommandAttribute is required");
            }

            commandValidatorFactory.GetInstance<TCommand>().ThrowExceptionIfInvalid(command);
        }

        private static bool HasCommandAttributeDefined(object command)
        {
            return command.GetType().IsDefined(typeof(CommandAttribute), false);
        }
    }
}