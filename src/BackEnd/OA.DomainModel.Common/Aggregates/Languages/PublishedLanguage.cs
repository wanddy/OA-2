namespace OA.DomainModel.Aggregates.Languages
{
    using System.Globalization;

    using OA.DomainModel.Events.Languages;
    using OA.Framework.DomainModel.Events;

    public class PublishedLanguage : Language
    {
        private PublishedLanguage(CultureInfo id)
            : base(id)
        {
            this.IsPublished = true;
        }

        public static PublishedLanguage CreateNew(CultureInfo culture)
        {
            return new PublishedLanguage(culture);
        }

        public HiddenLanguage Hide()
        {
            this.IsPublished = false;
            var hiddenLanguage = HiddenLanguage.CreateNew(this.Id);
            DomainEvents.Raise(new HidLanguageEvent(this.Id));
            return hiddenLanguage;
        }
    }
}