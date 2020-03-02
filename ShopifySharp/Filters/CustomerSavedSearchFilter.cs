using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering the results of one customer saved search.
    /// </summary>
    /// <remarks>
    /// Note: this is _not_ the same as _listing_ customer saved searches. This is for using one of those saved searches
    /// to list customers that match it.
    /// https://shopify.dev/docs/admin-api/rest/reference/customers/customersavedsearch#other-2020-01
    /// </remarks>
    public class CustomerSavedSearchFilter : Parameterizable
    {
        /// <summary>
        /// Set the field and direction by which to order results, e.g. "last_order_date DESC".
        /// </summary>
        [JsonProperty("order")]
        public string Order { get; set; }
        
        /// <summary>
        /// Retrieve only certain fields, specified by a comma-separated list of field names. 
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }
        
        /// <summary>
        /// The number of items which should be returned. Default is 50, maximum is 250.
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }
    }
}