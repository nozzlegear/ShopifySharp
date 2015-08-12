using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShopifySharp.Converters;
using System.Runtime.Serialization;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// The status of a fulfillment.
    /// </summary>
    [JsonConverter(typeof(ShopifyFulfillmentStatusConverter))]
    public enum ShopifyFulfillmentStatus
    {
        /// <summary>
        /// Every line item in the order has been fulfilled.
        /// </summary>
        [EnumMember(Value = "fulfilled")]
        Fulfilled,

        /// <summary>
        /// None of the line items in the order have been fulfilled.
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// At least one line item in the order has been fulfilled.
        /// </summary>
        [EnumMember(Value = "partial")]
        Partial
    }
}
