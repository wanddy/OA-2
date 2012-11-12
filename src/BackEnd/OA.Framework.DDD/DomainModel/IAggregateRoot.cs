namespace OA.Framework.DomainModel
{
    using System.Collections;

    public interface IAggregateRoot<out TId>
    {
        TId Id { get; }

        IEnumerable UncommitedEvents { get; }
    }
}