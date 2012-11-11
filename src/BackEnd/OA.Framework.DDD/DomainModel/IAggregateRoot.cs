namespace OA.Framework.DomainModel
{
    using System.Collections.Generic;

    public interface IAggregateRoot<out TId>
    {
        TId Id { get; }

        IEnumerable<object> UncommitedEvents { get; }
    }
}