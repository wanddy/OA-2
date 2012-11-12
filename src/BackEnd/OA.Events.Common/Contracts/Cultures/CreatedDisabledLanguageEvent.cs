namespace OA.Events.Contracts.Languages
{
    using System.Globalization;

    using OA.Framework.Common.Events;

    [Event]
    public class CreatedDisabledLanguageEvent
    {
        public CreatedDisabledLanguageEvent(CultureInfo culture)
        {
            this.Culture = culture;
        }

        public CultureInfo Culture { get; private set; }
    }
}