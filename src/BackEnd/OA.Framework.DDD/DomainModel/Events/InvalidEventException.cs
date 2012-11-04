namespace OA.Framework.DomainModel.Events
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class InvalidEventException : Exception
    {
        public InvalidEventException()
        {
        }

        public InvalidEventException(string message)
            : base(message)
        {
        }

        public InvalidEventException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected InvalidEventException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}