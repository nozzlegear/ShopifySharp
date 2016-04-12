using Newtonsoft.Json;
using ShopifySharp.Converters;
using System.Runtime.Serialization;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// An enum representing the type of <see cref="ShopifyScriptTag.Event"/>.
    /// </summary>
    [JsonConverter(typeof(NullableEnumConverter<ShopifyScriptTagEvent>))]
    public enum ShopifyScriptTagEvent
    {
        /// <summary>
        /// The script tag is triggered when the DOM fires the "Onload" event.
        /// </summary>
        [EnumMember(Value = "onload")]
        Onload
    }
}
