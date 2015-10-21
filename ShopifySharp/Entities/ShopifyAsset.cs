using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify asset. Assets do not have ids, but rather keys, and are associated with specific themes.
    /// </summary>
    public class ShopifyAsset
    {
        /// <summary>
        /// An asset attached to a store's theme.
        /// </summary>
        [JsonProperty("attachment")]
        public string Attachment { get; set; }

        /// <summary>
        /// MIME representation of the content, consisting of the type and subtype of the asset, 
        /// e.g. "image/gif"
        /// </summary>
        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// The date and time when the asset was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The path to the asset within a shop. For example, the asset bg-body-green.gif is located 
        /// in the assets folder.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// The public facing URL of the asset.
        /// </summary>
        [JsonProperty("public_url")]
        public string PublicUrl { get; set; }

        /// <summary>
        /// The asset size in bytes.
        /// </summary>
        [JsonProperty("size")]
        public long Size { get; set; }

        /// <summary>
        /// The source key copies an asset.
        /// </summary>
        [JsonProperty("source_key")]
        public string SourceKey { get; set; }

        /// <summary>
        /// Specifies the location of an asset.
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// A unique numeric identifier for the theme.
        /// </summary>
        [JsonProperty("theme_id")]
        public long ThemeId { get; set; }

        /// <summary>
        /// The date and time when an asset was last updated. 
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The asset that you are adding.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
