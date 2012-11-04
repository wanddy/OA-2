namespace OA.Framework.Common.Queries
{
    public abstract class QueryRepositoryDecoratorBase<TQuery, TResult> : IQueryRepository<TQuery, TResult>
    {
        protected QueryRepositoryDecoratorBase(IQueryRepository<TQuery, TResult> decoratedQueryRepository)
        {
            this.DecoratedQueryRepository = decoratedQueryRepository;
        }

        protected IQueryRepository<TQuery, TResult> DecoratedQueryRepository { get; private set; }

        public abstract TResult Execute(TQuery query);
    }
}