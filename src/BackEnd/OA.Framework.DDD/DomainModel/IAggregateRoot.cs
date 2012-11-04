namespace OA.Framework.DomainModel
{
    public interface IAggregateRoot<out TId>
    {
        TId Id { get; }
    }
}