namespace OA.Framework.Common.Events
{
    using System.Threading.Tasks;

    public static class EventDispatcher
    {
        private static IEventFactory eventFactory;

        public static void InitializeDomainEventFactory(IEventFactory factory)
        {
            eventFactory = factory;
        }

        public static void Raise<TEvent>(TEvent @event) where TEvent : class
        {
            ThrowExceptionIfInvalid(@event);
            Parallel.ForEach(eventFactory.FindAllInstances<TEvent>(), handler => handler.Raise(@event));
        }

        private static void ThrowExceptionIfInvalid<TEvent>(TEvent @event) where TEvent : class 
        {
            if (!@event.GetType().IsDefined(typeof(EventAttribute), false))
            {
                throw new InvalidEventException("DomainEventAttribute not defined");
            }
        }
    }
}