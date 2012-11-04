namespace OA.Framework.DomainModel.Events
{
    public interface IDomainEventHandler<in TEvent>
        where TEvent : class
    {
        void Raise(TEvent domainEvent);
    }
}