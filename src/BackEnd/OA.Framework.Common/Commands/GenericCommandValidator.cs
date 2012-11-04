namespace OA.Framework.Common.Commands
{
    public abstract class GenericCommandValidator<TCommand>
        where TCommand : class
    {
        public void ThrowExceptionIfInvalid(TCommand command)
        {
            if (!HasCommandAttributeDefined(command))
            {
                throw new InvalidCommandException("CommandAttribute is required");
            }

            this.ThrowExceptionIfInvalidData(command);
        }

        private static bool HasCommandAttributeDefined(object command)
        {
            return command.GetType().IsDefined(typeof(CommandAttribute), false);
        }

        protected abstract void ThrowExceptionIfInvalidData(TCommand command);
    }
}