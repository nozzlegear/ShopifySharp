using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// The type of discount.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShopifyDiscountCodeType
    {
        [EnumMember(Value = "percentage")]
        Percentage,

        [EnumMember(Value = "shipping")]
        Shipping,

        [EnumMember(Value = "fixed_amount")]
        FixedAmount
    }
}
