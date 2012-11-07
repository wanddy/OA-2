namespace OA.DomainModel.Aggregates.Cultures
{
    using System.Globalization;

    using OA.Framework.DomainModel;

    public abstract class Language : AggregateRootBase<CultureInfo>
    {
        protected Language(CultureInfo id)
            : base(id)
        {
        }

        protected Language()
        {
        }

        public virtual bool IsPublished { get; protected set; }
    }
}