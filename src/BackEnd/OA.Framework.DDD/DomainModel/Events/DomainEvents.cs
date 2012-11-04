namespace OA.Framework.DomainModel.Events
{
    using System.Threading.Tasks;

    public static class DomainEvents
    {
        private static IDomainEventFactory domainEventFactory;

        public static void InitializeDomainEventFactory(IDomainEventFactory factory)
        {
            domainEventFactory = factory;
        }

        public static void Raise<TEvent>(TEvent domainEvent) where TEvent : class
        {
            ThrowExceptionIfInvalid(domainEvent);
            Parallel.ForEach(domainEventFactory.FindAllInstances<TEvent>(), handler => handler.Raise(domainEvent));
        }

        private static void ThrowExceptionIfInvalid<TEvent>(TEvent domainEvent) where TEvent : class 
        {
            if (!domainEvent.GetType().IsDefined(typeof(DomainEventAttribute), false))
            {
                throw new InvalidEventException("DomainEventAttribute not defined");
            }
        }
    }
}