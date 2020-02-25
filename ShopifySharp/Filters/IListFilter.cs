using System.Collections.Generic;

namespace ShopifySharp.Filters
{
    public interface IListFilter<T>
    {
        /// <summary>
        /// A unique ID used to access a page of results. Must be present to list more than the first page of results. 
        /// </summary>
        string PageInfo { get; }

        /// <summary>
        /// The number of items which should be returned. Default is 50, maximum is 250.
        /// </summary>
        int? Limit { get; }

        /// <summary>
        /// Converts the filter to a list of key/value pairs which can be turned into a querystring.
        /// </summary>
        IEnumerable<KeyValuePair<string, object>> ToQueryParameters();
    }
}
