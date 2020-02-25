using System.Collections.Generic;

namespace ShopifySharp.Filters
{
    public interface ICountFilter
    {
        IEnumerable<KeyValuePair<string, object>> ToQueryParameters();
    }
}