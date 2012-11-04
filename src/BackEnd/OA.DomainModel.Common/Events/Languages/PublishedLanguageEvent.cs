namespace OA.DomainModel.Events.Languages
{
    using System.Globalization;

    using OA.Framework.DomainModel.Events;

    [DomainEvent]
    public class PublishedLanguageEvent
    {
        public PublishedLanguageEvent(CultureInfo culture)
        {
            this.Culture = culture;
        }

        public CultureInfo Culture { get; private set; }
    }
}