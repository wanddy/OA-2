namespace OA.Framework.Common.Events
{
    public interface IEventHandler<in TEvent>
        where TEvent : class
    {
        void Raise(TEvent @event);
    }
}