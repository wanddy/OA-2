namespace OA.DomainRepositories.DomainConverters
{
    public interface IDomainConverter<TDomain, TRepository>
    {
        TRepository Convert(TDomain domainEntity);
    }
}