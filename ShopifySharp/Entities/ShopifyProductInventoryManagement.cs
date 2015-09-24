using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShopifySharp
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShopifyProductInventoryManagement
    {
        /// <summary>
        /// Shopify does not track the number of items in stock for this product variant.
        /// </summary>
        [EnumMember(Value = "blank")]
        Blank,

        /// <summary>
        /// Shopify does track the number of items in stock for this product variant.
        /// </summary>
        [EnumMember(Value = "shopify")]
        Shopify,
    }
}