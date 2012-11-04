namespace OA.Framework.Common.Commands
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    using OA.Framework.Common.ExceptionHandling;

    public class DataAnnotationsCommandValidator<TCommand> : GenericCommandValidator<TCommand>,
                                                             ICommandValidator<TCommand>
        where TCommand : class
    {
        protected override void ThrowExceptionIfInvalidData(TCommand command)
        {
            var validationErrors = this.GetValidationErrors(command).ToArray();
            if (validationErrors.Any())
            {
                throw new InvalidCommandException("Invalid data") { BrokenRules = validationErrors.ToBrokenRules() };
            }
        }

        private IEnumerable<ValidationResult> GetValidationErrors(TCommand command)
        {
            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(command, null, null);
            Validator.TryValidateObject(command, context, validationResults, true);
            return validationResults;
        }
    }
}