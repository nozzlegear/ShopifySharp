using Newtonsoft.Json;
using System.Runtime.Serialization;
using ShopifySharp.Converters;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// The type of payment processing method
    /// </summary>
    [JsonConverter(typeof(NullableEnumConverter<ShopifyProcessingMethod>))]
    public enum ShopifyProcessingMethod
    {
        [EnumMember(Value = "checkout")]
        Checkout,

        [EnumMember(Value = "direct")]
        Direct,

        [EnumMember(Value = "manual")]
        Manual,

        [EnumMember(Value = "offsite")]
        Offsite,

        [EnumMember(Value = "express")]
        Express,

        [EnumMember(Value = "free")]
        Free,

        [EnumMember(Value = "none")]
        None
    }
}
