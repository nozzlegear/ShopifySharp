using System.Runtime.Serialization;
using Newtonsoft.Json;
using ShopifySharp.Converters;

namespace ShopifySharp.Enums
{
    [JsonConverter(typeof(NullableEnumConverter<ShopifyProductInventoryManagement>))]
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