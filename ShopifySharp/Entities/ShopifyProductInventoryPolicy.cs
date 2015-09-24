using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShopifySharp
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShopifyProductInventoryPolicy
    {
        /// <summary>
        /// Customers are not allowed to place orders for a product variant when it's out of stock.
        /// </summary>
        [EnumMember(Value = "deny")]
        Deny,

        /// <summary>
        /// Customers are allowed to place orders for a product variatn when it's out of stock.
        /// </summary>
        [EnumMember(Value = "continue")]
        Continue,
    }
}