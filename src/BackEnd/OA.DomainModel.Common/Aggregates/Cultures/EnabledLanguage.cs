namespace OA.DomainModel.Aggregates.Cultures
{
    using System;
    using System.Globalization;

    using OA.Events.Contracts.Languages;
    using OA.Framework.Common.Events;

    public class EnabledLanguage : Language
    {
        private EnabledLanguage(Guid id, CultureInfo culture)
            : base(id, culture)
        {
        }

        protected EnabledLanguage()
        {
        }

        public static EnabledLanguage CreateNew(CultureInfo culture)
        {
            return new EnabledLanguage(Guid.NewGuid(), culture);
        }

        public virtual DisabledLanguage Disable()
        {
            var hiddenLanguage = DisabledLanguage.CreateNew(this.Id);
            EventDispatcher.Raise(new DisabledLanguageEvent(this.Id));
            return hiddenLanguage;
        }
    }
}