using System;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering lists of ProductListings. 
    /// </summary>
    public class ProductListingListFilter : ListFilter<ProductListing>
    {
        /// <summary>
        /// Filter by collection id.
        /// </summary>
        [JsonProperty("collection_id")]
        public long? CollectionId { get; set; }

        /// <summary>
        /// Filter by product handle.
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; }

        /// <summary>
        /// A comma-separated list of product ids
        /// </summary>
        [JsonProperty("product_ids")]
        public string ProductIds { get; set; }

        /// <summary>
        /// Show those updated at or before date (formatted in ISO 8601)
        /// </summary>
        [JsonProperty("updated_at_min")]
        public DateTimeOffset? UpdatedAtMin { get; set; }
    }
}
