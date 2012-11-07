namespace OA.DomainModel.Aggregates.Cultures
{
    using System.Globalization;

    using OA.Events.Contracts.Languages;
    using OA.Framework.Common.Events;

    public class EnabledLanguage : Language
    {
        private EnabledLanguage(CultureInfo id)
            : base(id)
        {
            this.IsPublished = true;
        }

        protected EnabledLanguage()
        {
        }

        public static EnabledLanguage CreateNew(CultureInfo culture)
        {
            return new EnabledLanguage(culture);
        }

        public virtual DisabledLanguage Disable()
        {
            this.IsPublished = false;
            var hiddenLanguage = DisabledLanguage.CreateNew(this.Id);
            EventDispatcher.Raise(new DisabledLanguageEvent(this.Id));
            return hiddenLanguage;
        }
    }
}