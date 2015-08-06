using Newtonsoft.Json;
using ShopifySharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyDiscountCode
    {
        /// <summary>
        /// The amount of the discount.
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// The discount code.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// The type of discount.
        /// </summary>
        [JsonProperty("type")]
        public ShopifyDiscountCodeType Type { get; set; }
    }
}
