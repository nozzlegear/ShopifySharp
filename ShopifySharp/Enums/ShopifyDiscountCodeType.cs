using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// The type of discount.
    /// </summary>
    public enum ShopifyDiscountCodeType
    {
        [JsonProperty("percentage")]
        Percentage,

        [JsonProperty("shipping")]
        Shipping,

        [JsonProperty("fixed_amount")]
        FixedAmount
    }
}
