namespace OA.Framework.Common.Events
{
    public abstract class EventHandlerDecoratorBase<TEvent> : IEventHandler<TEvent>
        where TEvent : class
    {
        protected EventHandlerDecoratorBase(IEventHandler<TEvent> decoratedEventHandler)
        {
            this.DecoratedEventHandler = decoratedEventHandler;
        }

        protected IEventHandler<TEvent> DecoratedEventHandler { get; set; }

        public abstract void Raise(TEvent @event);
    }
}