namespace OA.DomainModel.Aggregates.Cultures
{
    using System;
    using System.Globalization;

    using OA.Events.Contracts.Languages;
    using OA.Framework.Common.Events;

    public class DisabledLanguage : Language
    {
        public DisabledLanguage(CultureInfo culture)
        {
            
        }

        private DisabledLanguage(Guid id, CultureInfo culture)
            : base(id, culture)
        {

        }

        protected DisabledLanguage()
        {
        }

        public static DisabledLanguage CreateNew(CultureInfo culture)
        {
            return new DisabledLanguage(Guid.NewGuid(), culture);
        }

        public virtual EnabledLanguage Enable()
        {
            var publishedLanguage = EnabledLanguage.CreateNew(this.Culture);
            EventDispatcher.Raise(new EnabledLanguageEvent(this.Id));
            return publishedLanguage;
        }
    }
}