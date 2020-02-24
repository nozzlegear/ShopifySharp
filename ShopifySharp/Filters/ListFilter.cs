using Newtonsoft.Json;
using System.Collections.Generic;
using System.Reflection;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// A generic class for filtering the results of a .ListAsync command.
    /// </summary>
    public class ListFilter : IListFilter
    {
        /// <summary>
        /// A unique ID used to access a page of results. Must be present to list more than the first page of results. 
        /// </summary>
        [JsonProperty("page_info")]
        public string PageInfo { get; set; }

        /// <summary>
        /// The number of items which should be returned. Default is 50, maximum is 250.
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        public virtual IEnumerable<KeyValuePair<string, object>> ToQueryParameters()
        {
            throw new System.NotImplementedException();
        }
    }
}
