using Newtonsoft.Json;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a properties for <see cref="LineItem.Properties"/>
    /// </summary>
    public class LineItemProperty
    {
        /// <summary>
        /// The name of the note attribute.
        /// </summary>
        [JsonProperty("name")]
        public object Name { get; set; }

        /// <summary>
        /// The value of the note attribute.
        /// </summary>
        [JsonProperty("value")]
        public object Value { get; set; }
    }
}
