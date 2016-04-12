using Newtonsoft.Json;
using System.Runtime.Serialization;
using ShopifySharp.Converters;

namespace ShopifySharp.Enums
{
    [JsonConverter(typeof(NullableEnumConverter<ShopifyOrderStatus>))]
    public enum ShopifyOrderStatus
    {
        [EnumMember(Value = "open")]
        Open,

        [EnumMember(Value = "closed")]
        Closed,

        [EnumMember(Value = "cancelled")]
        Cancelled,

        [EnumMember(Value = "any")]
        Any
    }
}
