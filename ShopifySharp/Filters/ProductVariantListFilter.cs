using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering lists of Product Variants. 
    /// </summary>
    public class ProductVariantListFilter : ListFilter<ProductVariant>
    {
        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }
        
        /// <summary>
        /// Return presentment prices in only certain currencies. Each entry must be an ISO 4217 valid currency code.
        /// </summary>
        [JsonProperty("presentment_currencies")]
        public IEnumerable<string> PresentmentCurrencies { get; set; }
    }
}