using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShopifySharp.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShopifyProductFulfillmentService
    {
        [EnumMember(Value = "manual")]
        Manual,
    }
}