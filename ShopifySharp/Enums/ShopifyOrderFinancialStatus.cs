using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// The financial status of an order.
    /// </summary>
    public enum ShopifyOrderFinancialStatus
    {
        /// <summary>
        /// The finances are pending.
        /// </summary>
        [JsonProperty("pending")]
        Pending,

        /// <summary>
        /// The finances have been authorized.
        /// </summary>
        [JsonProperty("authorized")]
        Authorized,

        /// <summary>
        /// The finances have been partially paid.
        /// </summary>
        [JsonProperty("partially_paid")]
        PartiallyPaid,

        /// <summary>
        /// The finances have been paid. (This is the default value.)
        /// </summary>
        [JsonProperty("paid")]
        Paid,

        /// <summary>
        /// The finances have been partially refunded.
        /// </summary>
        [JsonProperty("partially_refunded")]
        PartiallyRefunded,

        /// <summary>
        /// The finances have been refunded.
        /// </summary>
        [JsonProperty("refunded")]
        Refunded,

        /// <summary>
        /// The finances have been voided.
        /// </summary>
        [JsonProperty("voided")]
        Voided
    }
}
