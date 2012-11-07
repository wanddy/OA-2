namespace OA.Framework.Common.Events
{
    using System.Collections.Generic;

    public interface IEventFactory
    {
        IEnumerable<IEventHandler<TEvent>> FindAllInstances<TEvent>() where TEvent : class;
    }
}