namespace OA.Framework.DomainModel.Events
{
    using System.Collections.Generic;

    public interface IDomainEventFactory
    {
        IEnumerable<IDomainEventHandler<TEvent>> FindAllInstances<TEvent>() where TEvent : class;
    }
}