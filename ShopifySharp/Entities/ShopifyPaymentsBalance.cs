using Newtonsoft.Json;
using System;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify payments balance.
    /// </summary>
    public class ShopifyPaymentsBalance
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public decimal? Amount { get; set; }
    }
}
