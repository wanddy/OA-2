namespace OA.DomainRepositories.DomainConverters.Cultures
{
    using OA.DomainModel.Aggregates.Cultures;

    using Language = OA.DomainRepositories.RepositoryModel.Cultures.Language;

    public class LanguageConverter : IDomainConverter<DomainModel.Aggregates.Cultures.Language, Language>
    {
        static LanguageConverter()
        {
            AutoMapper.Mapper.CreateMap<DomainModel.Aggregates.Cultures.Language, Language>()
                .Include<EnabledLanguage, Language>()
                    .ForMember(language => language.IsEnabled, expression => expression.UseValue(true))
                .Include<DisabledLanguage, Language>()
                    .ForMember(language => language.IsEnabled, expression => expression.UseValue(false));
        }

        public Language Convert(DomainModel.Aggregates.Cultures.Language domainEntity)
        {
            return AutoMapper.Mapper.Map<Language>(domainEntity);
        }
    }
}