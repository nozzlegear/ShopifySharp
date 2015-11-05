using Newtonsoft.Json;
using ShopifySharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyProductFilterOptions : ShopifyFilterOptions
    {
        /// <summary>
        /// An optional array of order ids to retrieve. 
        /// </summary>
        public IEnumerable<long> Ids { get; set; }

        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; } = null;

        /// <summary>
        /// Filter by product title.
        /// </summary>
        [JsonProperty("title")]
        public long? Title { get; set; } = null;

        /// <summary>
        /// Filter by product vendor.
        /// </summary>
        [JsonProperty("vendor")]
        public long? Vendor { get; set; } = null;

        /// <summary>
        /// Filter by product handle.
        /// </summary>
        [JsonProperty("handle")]
        public long? Handle { get; set; } = null;

        /// <summary>
        /// Filter by product type.
        /// </summary>
        [JsonProperty("product_type")]
        public long? ProductType { get; set; } = null;

        /// <summary>
        /// Filter by collection id.
        /// </summary>
        [JsonProperty("collecion_id")]
        public long? CollectionId { get; set; } = null;

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
