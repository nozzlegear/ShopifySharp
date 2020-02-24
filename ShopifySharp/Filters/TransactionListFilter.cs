using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    public class TransactionListFilter : UnpaginatedListFilter
    {
        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }
        
        /// <summary>
        /// Retrieve only certain fields, specified by a comma-separated list of field names. 
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }
        
        /// <summary>
        /// Show amounts in the shop currency. 
        /// </summary>
        [JsonProperty("in_shop_currency")]
        public bool? InShopCurrency { get; set; }
    }
}