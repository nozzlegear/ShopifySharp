using Newtonsoft.Json;
using System.Collections.Generic;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// A generic class for filtering the results of a .ListAsync command.
    /// </summary>
    public class ListFilter<T> : Parameterizable, IListFilter<T>
    {
        /// <summary>
        /// A unique ID used to access a page of results. Must be present to list more than the first page of results. 
        /// </summary>
        [JsonProperty("page_info")]
        public string PageInfo { get; }

        /// <summary>
        /// The number of items which should be returned. Default is 50, maximum is 250.
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        internal ListFilter()
        {
        }

        internal ListFilter(string pageInfo, int? limit)
        {
            PageInfo = pageInfo;
            Limit = limit;
        }
    }
}
