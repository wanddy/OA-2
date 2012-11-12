namespace OA.Framework.DomainRepositories
{
    using OA.Framework.DomainModel;

    public interface IAggregateRootDomainRepository<TAggregate, in TId> : IAggregateDomainRepository<TAggregate, TId>
        where TAggregate : IAggregateRoot<TId>
    {
        void Save(TAggregate aggregateRoot);
    }
}