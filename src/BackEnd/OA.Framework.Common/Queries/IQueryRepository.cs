namespace OA.Framework.Common.Queries
{
    public interface IQueryRepository<in TQuery, out TResult>
    {
        TResult Execute(TQuery query);
    }
}