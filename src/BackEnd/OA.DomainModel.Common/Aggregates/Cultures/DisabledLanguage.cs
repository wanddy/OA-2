namespace OA.DomainModel.Aggregates.Cultures
{
    using System.Globalization;

    using OA.Events.Contracts.Languages;
    using OA.Framework.Common.Events;

    public class DisabledLanguage : Language
    {
        private DisabledLanguage(CultureInfo id)
            : base(id)
        {
        }

        protected DisabledLanguage()
        {
        }

        public static DisabledLanguage CreateNew(CultureInfo culture)
        {
            return new DisabledLanguage(culture);
        }

        public virtual EnabledLanguage Enable()
        {
            this.IsPublished = true;
            var publishedLanguage = EnabledLanguage.CreateNew(this.Id);
            EventDispatcher.Raise(new EnabledLanguageEvent(this.Id));
            return publishedLanguage;
        }
    }
}