namespace OA.Framework.Common.Queries
{
    using OA.Framework.Common.Caching;

    public class CachedQueryRepositoryDecorator<TQuery, TResult> : QueryRepositoryDecoratorBase<TQuery, TResult>
    {
        private readonly ICacheStorage cacheStorage;

        public CachedQueryRepositoryDecorator(
            IQueryRepository<TQuery, TResult> decoratedQueryRepository, ICacheStorage cacheStorage)
            : base(decoratedQueryRepository)
        {
            this.cacheStorage = cacheStorage;
        }

        public override TResult Execute(TQuery query)
        {
            var key = this.GetCacheKey(query);
            var results = this.cacheStorage.Retrieve<TResult>(key);
            if (results.Equals(default(TResult)))
            {
                results = this.DecoratedQueryRepository.Execute(query);
                this.cacheStorage.Store(key, results);
            }

            return results;
        }

        protected virtual string GetCacheKey(TQuery query)
        {
            return query.GetType().FullName;
        }
    }
}