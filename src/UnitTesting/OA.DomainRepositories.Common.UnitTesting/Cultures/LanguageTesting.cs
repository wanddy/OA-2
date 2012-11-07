namespace OA.DomainRepositories.UnitTesting.Cultures
{
    using System.Globalization;

    using NHibernate;
    using NHibernate.Cfg;

    using NUnit.Framework;

    using OA.DomainModel.Aggregates.Cultures;
    using OA.DomainRepositories.DomainConverters.Cultures;

    [TestFixture]
    public class LanguageTesting
    {
        private readonly ISessionFactory sessionFactory;

        private readonly LanguageConverter languageConverter;

        public LanguageTesting()
        {
            this.sessionFactory = new Configuration().Configure().BuildSessionFactory();
            this.languageConverter = new LanguageConverter();
        }

        [Test]
        public void CreateALanguageIsOk()
        {
            Assert.That(
                () =>
                    {
                        var language = DisabledLanguage.CreateNew(CultureInfo.CurrentCulture);
                        using (var openSession = this.sessionFactory.OpenSession())
                        using (var tx = openSession.BeginTransaction())
                        {
                            openSession.Merge(this.languageConverter.Convert(language));
                            tx.Commit();
                        }
                    },
                Throws.Nothing);
        }

        [Test]
        public void ChangeHiddenToPublished()
        {
            Assert.That(
                () =>
                    {
                        var language = EnabledLanguage.CreateNew(CultureInfo.CurrentCulture);
                        using (var openSession = this.sessionFactory.OpenSession())
                        using (var tx = openSession.BeginTransaction())
                        {
                            openSession.Merge(this.languageConverter.Convert(language));
                            tx.Commit();
                        }
                    },
                Throws.Nothing);
        }
    }
}