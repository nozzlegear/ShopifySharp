using Newtonsoft.Json;
using System;

namespace ShopifySharp
{
    /// <summary>
    /// Represents a Shopify article's image.
    /// </summary>
    public class ShopifyArticleImage
    {
        /// <summary>
        /// A base64 image string only used when creating an image. It will be converted to the <see cref="Src"/> property.
        /// </summary>
        [JsonProperty("attachment")]
        public string Attachment { get; set; }

        /// <summary>
        /// The date and time the image was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The image's src URL.
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }
    }
}
