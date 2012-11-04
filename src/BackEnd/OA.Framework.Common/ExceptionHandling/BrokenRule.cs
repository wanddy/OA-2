namespace OA.Framework.Common.ExceptionHandling
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public class BrokenRule
    {
        public BrokenRule(IEnumerable<string> memberNames, string message)
        {
            this.MemberNames = memberNames;
            this.Message = message;
        }

        private BrokenRule()
        {
        }

        public IEnumerable<string> MemberNames { get; private set; }

        public string Message { get; private set; }
    }
}