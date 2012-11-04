namespace OA.DomainModel.Aggregates.Languages
{
    using System.Globalization;

    using OA.DomainModel.Events.Languages;
    using OA.Framework.DomainModel.Events;

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
            DomainEvents.Raise(new PublishedLanguageEvent(this.Id));
            return publishedLanguage;
        }
    }
}