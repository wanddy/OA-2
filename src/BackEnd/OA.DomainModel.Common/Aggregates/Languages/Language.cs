namespace OA.DomainModel.Aggregates.Languages
{
    using System.Globalization;

    using OA.Framework.DomainModel;

    public abstract class Language : AggregateRootBase<CultureInfo>
    {
        protected Language(CultureInfo id)
            : base(id)
        {
        }

        public bool IsPublished { get; protected set; }
    }
}