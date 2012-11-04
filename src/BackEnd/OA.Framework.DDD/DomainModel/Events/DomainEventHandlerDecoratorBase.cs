namespace OA.Framework.DomainModel.Events
{
    public abstract class DomainEventHandlerDecoratorBase<TEvent> : IDomainEventHandler<TEvent>
        where TEvent : class
    {
        protected DomainEventHandlerDecoratorBase(IDomainEventHandler<TEvent> decoratedEventHandler)
        {
            this.DecoratedEventHandler = decoratedEventHandler;
        }

        protected IDomainEventHandler<TEvent> DecoratedEventHandler { get; set; }

        public abstract void Raise(TEvent domainEvent);
    }
}