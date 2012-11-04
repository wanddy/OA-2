namespace OA.Framework.Common.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    using OA.Framework.Common.ExceptionHandling;

    [Serializable]
    public class InvalidCommandException : Exception
    {
        private const string BrokenRulesKey = "BrokenRules";

        public InvalidCommandException()
        {
        }

        public InvalidCommandException(string message)
            : base(message)
        {
        }

        public InvalidCommandException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected InvalidCommandException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public IEnumerable<BrokenRule> BrokenRules
        {
            get
            {
                if (!this.Data.Contains(BrokenRulesKey))
                {
                    return Enumerable.Empty<BrokenRule>();
                }

                return this.Data[BrokenRulesKey] as IEnumerable<BrokenRule> ?? Enumerable.Empty<BrokenRule>();
            }

            set
            {
                this.Data[BrokenRulesKey] = value ?? Enumerable.Empty<BrokenRule>();
            }
        }
    }
}