using Newtonsoft.Json;
using System.Runtime.Serialization;
using ShopifySharp.Converters;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// The type of discount.
    /// </summary>
    [JsonConverter(typeof(NullableEnumConverter<ShopifyDiscountCodeType>))]
    public enum ShopifyDiscountCodeType
    {
        /// <summary>
        /// Discount is a percentage.
        /// </summary>
        [EnumMember(Value = "percentage")]
        Percentage,

        /// <summary>
        /// Discount is for shipping.
        /// </summary>
        [EnumMember(Value = "shipping")]
        Shipping,

        /// <summary>
        /// Discount is a fixed amount.
        /// </summary>
        [EnumMember(Value = "fixed_amount")]
        FixedAmount,

        /// <summary>
        /// No discount.
        /// </summary>
        [EnumMember(Value = "none")]
        None,
    }
}
