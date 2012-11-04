namespace OA.Framework.Common.Caching
{
    public class NullCacheStorage : ICacheStorage
    {
        public TValue Retrieve<TValue>(string key)
        {
            return default(TValue);
        }

        public void Store(string key, object value)
        {
        }

        public void Remove(string key)
        {
        }
    }
}