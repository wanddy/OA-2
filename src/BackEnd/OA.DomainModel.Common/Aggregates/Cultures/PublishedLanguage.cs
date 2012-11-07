namespace OA.DomainModel.Aggregates.Cultures
{
    using System.Globalization;

    using OA.Events.Contracts.Languages;
    using OA.Framework.Common.Events;

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
            EventDispatcher.Raise(new HidLanguageEvent(this.Id));
            return hiddenLanguage;
        }
    }
}