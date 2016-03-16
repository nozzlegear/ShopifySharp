using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// Options for filtering <see cref="ShopifyCustomCollectionService"/> requests.
    /// </summary>
    public class ShopifyCustomCollectionFilterOptions : ShopifyListFilter
    {
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
