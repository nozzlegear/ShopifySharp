using Newtonsoft.Json;
using System;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing the image for a <see cref="ShopifySmartCollection"/>.
    /// </summary>
    public class ShopifySmartCollectionImage
    {
        /// <summary>
        /// The date the image was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The image's source URL.
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }

        /// <summary>
        /// The image's base64 attachment, used when creating an image.
        /// </summary>
        [JsonProperty("attachment")]
        public string Attachment { get; set; }
    }
}
