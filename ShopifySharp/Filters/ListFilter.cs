using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// A generic class for filtering the results of a .ListAsync command.
    /// </summary>
    public class ListFilter<T> : Parameterizable
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
        
        /// <summary>
        /// Comma-separated list of which fields to show in the results. This parameter only works for some endpoints.
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }
        
        /// <remarks>
        /// This constructor is protected to prevent developers from using `new ListFilter()`, but to make creating your
        /// own ListFilter easier.
        /// https://github.com/nozzlegear/shopifysharp/issues/515
        /// </remarks>
        protected ListFilter()
        {
            
        }

        public ListFilter(string pageInfo, int? limit, string fields = null)
        {
            PageInfo = pageInfo;
            Limit = limit;
            Fields = fields;
        }

        public ListFilter<T> AsListFilter() => this; 

        public static readonly ListFilter<T> Empty = new ListFilter<T>();
    }
}
