namespace OA.Framework.DomainRepositories
{
    using System.Collections.Generic;

    public interface IAggregateDomainRepository<out TAggregate, in TId>
    {
        TAggregate FindBy(TId id);

        IEnumerable<TAggregate> FindAll();
    }
}