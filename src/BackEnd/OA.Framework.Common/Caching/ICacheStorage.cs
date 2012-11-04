namespace OA.Framework.Common.Caching
{
    public interface ICacheStorage
    {
        TValue Retrieve<TValue>(string key);

        void Store(string key, object value);

        void Remove(string key);
    }
}