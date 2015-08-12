using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// The kind of transaction.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShopifyTransactionKind
    {
        /// <summary>
        /// Money that the customer has agreed to pay. Authorization period lasts for up to 7 to 30 days (depending on your payment service) while a store awaits for a customer's capture.
        /// </summary>
        [EnumMember(Value = "authorization")] 
        Authorization,

        /// <summary>
        /// Transfer of money that was reserved during the authorization of a shop.
        /// </summary>
        [EnumMember(Value = "capture")]
        Capture,

        /// <summary>
        /// The combination of authorization and capture, performed in one single step.
        /// </summary>
        [EnumMember(Value = "sale")]
        Sale,

        /// <summary>
        /// The cancellation of a pending authorization or capture.
        /// </summary>
        [EnumMember(Value = "void")]
        Void,

        /// <summary>
        /// The partial or full return of the captured money to the customer.
        /// </summary>
        [EnumMember(Value = "refund")]
        Refund
    }
}
