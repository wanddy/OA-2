namespace OA.DomainModel.Aggregates.Cultures
{
    using System;
    using System.Globalization;

    using OA.Framework.DomainModel;

    public abstract class Language : AggregateRootBase<Guid>
    {
        protected Language(Guid id, CultureInfo culture)
            : base(id)
        {
            this.Culture = culture;
        }

        protected Language()
        {
        }

        public CultureInfo Culture { get; private set; }
    }
}