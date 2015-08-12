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
    /// The financial status of an order.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShopifyOrderFinancialStatus
    {
        /// <summary>
        /// The finances are pending.
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,

        /// <summary>
        /// The finances have been authorized.
        /// </summary>
        [EnumMember(Value = "authorized")]
        Authorized,

        /// <summary>
        /// The finances have been partially paid.
        /// </summary>
        [EnumMember(Value = "partially_paid")]
        PartiallyPaid,

        /// <summary>
        /// The finances have been paid. (This is the default value.)
        /// </summary>
        [EnumMember(Value = "paid")]
        Paid,

        /// <summary>
        /// The finances have been partially refunded.
        /// </summary>
        [EnumMember(Value = "partially_refunded")]
        PartiallyRefunded,

        /// <summary>
        /// The finances have been refunded.
        /// </summary>
        [EnumMember(Value = "refunded")]
        Refunded,

        /// <summary>
        /// The finances have been voided.
        /// </summary>
        [EnumMember(Value = "voided")]
        Voided
    }
}
