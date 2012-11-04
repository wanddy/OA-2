namespace OA.Framework.Common.Caching
{
    using System.Web;

    public class HttpContextCacheStorageAdapter : ICacheStorage
    {
        public TValue Retrieve<TValue>(string key)
        {
            var cached = HttpContext.Current.Cache[key];
            if (cached == null)
            {
                return default(TValue);
            }

            return (TValue)cached;
        }

        public void Store(string key, object value)
        {
            HttpContext.Current.Cache.Insert(key, value);
        }

        public void Remove(string key)
        {
            HttpContext.Current.Cache.Remove(key);
        }
    }
}