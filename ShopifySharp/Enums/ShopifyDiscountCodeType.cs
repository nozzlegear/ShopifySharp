using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using ShopifySharp.Converters;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// The type of discount.
    /// </summary>
    [JsonConverter(typeof(ShopifyDiscountCodeConverter))]
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
