namespace OA.DomainModel.Aggregates.Cultures
{
    using System.Globalization;

    using OA.Events.Contracts.Languages;
    using OA.Framework.Common.Events;

    public class HiddenLanguage : Language
    {
        private HiddenLanguage(CultureInfo id)
            : base(id)
        {
        }

        public static HiddenLanguage CreateNew(CultureInfo culture)
        {
            return new HiddenLanguage(culture);
        }

        public PublishedLanguage Publish()
        {
            this.IsPublished = true;
            var publishedLanguage = PublishedLanguage.CreateNew(this.Id);
            EventDispatcher.Raise(new PublishedLanguageEvent(this.Id));
            return publishedLanguage;
        }
    }
}