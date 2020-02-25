using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    public class UsageChargeListFilter : UnpaginatedListFilter<UsageCharge>
    {
        /// <summary>
        /// Retrieve only certain fields, specified by a comma-separated list of field names. 
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }
    }
}