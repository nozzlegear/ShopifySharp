using System;
using Newtonsoft.Json;

namespace ShopifySharp
{
    public class CollectionImage 
    {
        /// <summary>
        /// An image attached to a collection returned as Base64-encoded binary data.
        /// </summary>
        [JsonProperty("attachment")]
        public string Attachment { get; set; }
        
        /// <summary>
        /// The source URL that specifies the location of the image.
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }
        
        /// <summary>
        /// The alternative text that describes the collection image.
        /// </summary>
        [JsonProperty("alt")]
        public string Alt { get; set; }
        
        /// <summary>
        /// The time and date (ISO 8601 format) when the image was added to the collection.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        /// <summary>
        /// The width of the image in pixels.
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }
        
        /// <summary>
        /// The height of the image in pixels.
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }
    }
}