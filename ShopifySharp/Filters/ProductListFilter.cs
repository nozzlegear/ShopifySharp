using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering lists of Products. 
    /// </summary>
    public class ProductListFilter : ListFilter<Product>
    {
        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }
        
        /// <summary>
        /// Filter by product title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Filter by product vendor.
        /// </summary>
        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// Filter by product handle.
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; }

        /// <summary>
        /// Filter by product type.
        /// </summary>
        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// Filter by collection id.
        /// </summary>
        [JsonProperty("collection_id")]
        public long? CollectionId { get; set; }
        
        /// <summary>
        /// Show those created at or after date.
        /// </summary>
        [JsonProperty("created_at_min")]
        public DateTimeOffset? CreatedAtMin { get; set; }

        /// <summary>
        /// Show those created at or after date.
        /// </summary>
        [JsonProperty("created_at_max")]
        public DateTimeOffset? CreatedAtMax { get; set; }
        
        /// <summary>
        /// Show those updated at or before date.
        /// </summary>
        [JsonProperty("updated_at_min")]
        public DateTimeOffset? UpdatedAtMin { get; set; }

        /// <summary>
        /// Show those last updated at or before date.
        /// </summary>
        [JsonProperty("updated_at_max")]
        public DateTimeOffset? UpdatedAtMax { get; set; }
        
        /// <summary>
        /// Show those published at or before date.
        /// </summary>
        [JsonProperty("published_at_min")]
        public DateTimeOffset? PublishedAtMin { get; set; }

        /// <summary>
        /// Show those last published at or before date.
        /// </summary>
        [JsonProperty("published_at_max")]
        public DateTimeOffset? PublishedAtMax { get; set; }
        
        /// <summary>
        /// Restricts results to those with the given published status. Known values: published, unpublished, any. Default: any.
        /// </summary>
        [JsonProperty("published_status")]
        public string PublishedStatus { get; set; }
        
        /// <summary>
        /// Return presentment prices in only certain currencies. Each entry must be an ISO 4217 valid currency code.
        /// </summary>
        [JsonProperty("presentment_currencies")]
        public IEnumerable<string> PresentmentCurrencies { get; set; }
        
        /// <summary>
        /// Retrieve only those specified by a comma-separated list of order IDs.
        /// </summary>
        [JsonProperty("ids")]
        public IEnumerable<long> Ids { get; set; }
    }
}
