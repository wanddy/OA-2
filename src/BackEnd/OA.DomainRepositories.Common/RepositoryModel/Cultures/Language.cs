namespace OA.DomainRepositories.RepositoryModel.Cultures
{
    using System.Globalization;

    public class Language
    {
        public Language(CultureInfo id, bool isEnabled)
        {
            this.Id = id;
            this.IsEnabled = isEnabled;
        }

        protected Language()
        {
        }

        public virtual CultureInfo Id { get; set; }

        public virtual bool IsEnabled { get; set; }
    }
}