namespace OA.Framework.DomainModel
{
    public interface IAggregateRootRepository<TAggregate, in TId>
        where TAggregate : IAggregateRoot<TId>
    {
        TAggregate FindBy(TId id);

        void Save(TAggregate aggregate);

        void Remove(TAggregate aggregate);
    }
}