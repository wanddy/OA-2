namespace OA.DomainModel.Aggregates.Cultures
{
    using System.Globalization;

    using OA.Framework.DomainModel;

    public class Currency : AggregateRootBase<CultureInfo>
    {
        private Currency(CultureInfo culture)
            : base(culture)
        {
        }

        protected Currency()
        {
        }

        public static Currency CreateNew(CultureInfo culture)
        {
            return new Currency(culture);
        }
    }
}