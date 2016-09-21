using Newtonsoft.Json;
using ShopifySharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// An entity representing a Shopify theme.
    /// </summary>
    public class ShopifyTheme : ShopifyObject
    {
        /// <summary>
        /// The date and time when the theme was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The name of the theme.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Specifies how the theme is being used within the shop. Known values are 'main', 'mobile' and 'unpublished'.
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }

        /// <summary>
        /// The date and time when the theme was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Indicates if the theme can currently be previewed.
        /// </summary>
        [JsonProperty("previewable")]
        public bool Previewable { get; set; }

        /// <summary>
        /// Indicates if files are still being copied into place for this theme.
        /// </summary>
        [JsonProperty("processing")]
        public bool Processing { get; set; }

        /// <summary>
        /// The theme's store id. Can be null if not published in the store.
        /// </summary>
        [JsonProperty("theme_store_id")]
        public long? ThemeStoreId { get; set; }
    }
}
