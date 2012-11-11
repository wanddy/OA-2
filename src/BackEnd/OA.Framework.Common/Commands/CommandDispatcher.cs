namespace OA.Framework.Common.Commands
{
    public static class CommandDispatcher
    {
        private static ICommandHandlerFactory commandHandlerFactory;

        public static void InitializeCommandHandlerFactory(ICommandHandlerFactory factory)
        {
            if (commandHandlerFactory == null)
            {
                commandHandlerFactory = factory;
            }
        }

        public static void Execute<TCommand>(TCommand command) where TCommand : class
        {
            if (!command.GetType().IsDefined(typeof(CommandAttribute), true))
            {
                throw new InvalidCommandException("CommandAttribute required");
            }

            commandHandlerFactory.GetHandlerFor<TCommand>().Execute(command);
        }
    }
}
