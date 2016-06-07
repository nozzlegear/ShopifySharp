using Newtonsoft.Json;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a properties for <see cref="ShopifyLineItem.Properties"/>
    /// </summary>
    public class ShopifyLineItemProperty
    {
        /// <summary>
        /// The name of the note attribute.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The value of the note attribute.
        /// </summary>
        [JsonProperty("value")]
        public object Value { get; set; }
    }
}