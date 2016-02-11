using Newtonsoft.Json;
using System;

namespace ShopifySharp
{
    public class ShopifySmartCollectionFilterOptions : ShopifyFilterOptions
    {

        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }

        /// <summary>
        /// Show smart collections with given title 
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Show smart collections that includes given product
        /// </summary>
        [JsonProperty("product_id")]
        public long? ProductId { get; set; }


        /// <summary>
        /// Filter by smart collection handle
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; }

        /// <summary>
        /// Show products created after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("created_at_min")]
        public DateTime? CreatedAtMin { get; set; } = null;

        /// <summary>
        /// Show products created before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("created_at_max")]
        public DateTime? CreateAtMax { get; set; } = null;

        /// <summary>
        /// Show products last updated after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_min")]
        public DateTime? UpdateAtMin { get; set; } = null;

        /// <summary>
        /// Show products last updated before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_max")]
        public DateTime? UpdateAtMax { get; set; } = null;

        /// <summary>
        /// Show products published after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("published_at_min")]
        public DateTime? PublishedAtMin { get; set; } = null;

        /// <summary>
        /// Show products published before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("published_at_max")]
        public DateTime? PublishedAtMax { get; set; } = null;

        /// <summary>
        /// Puublished Status.
        /// published - Show only published products, unpublished - Show only unpublished products, any - Show all products(default)
        /// </summary>
        [JsonProperty("published_status")]
        public string PublishedStatus { get; set; } = null;
    }
}
