namespace OA.Framework.Common.ExceptionHandling
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public static class ValidationResultMethodExtensions
    {
        public static IEnumerable<BrokenRule> ToBrokenRules(this IEnumerable<ValidationResult> validationResults)
        {
            return validationResults.Select(result => new BrokenRule(result.MemberNames, result.ErrorMessage));
        }
    }
}