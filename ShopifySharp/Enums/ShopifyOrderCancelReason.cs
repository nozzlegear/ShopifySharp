using Newtonsoft.Json;
using System.Runtime.Serialization;
using ShopifySharp.Converters;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// The reason why an order was cancelled.
    /// </summary>
    [JsonConverter(typeof(NullableEnumConverter<ShopifyOrderCancelReason>))]
    public enum ShopifyOrderCancelReason
    {
        /// <summary>
        /// The customer changed or cancelled the order.
        /// </summary>
        [EnumMember(Value = "customer")]
        Customer,

        /// <summary>
        /// The order was fraudulent.
        /// </summary>
        [EnumMember(Value = "fraud")]
        Fraud,

        /// <summary>
        /// Items in the order were not in inventory.
        /// </summary>
        [EnumMember(Value = "inventory")]
        Inventory,

        /// <summary>
        /// The order was cancelled for a reason not in the list above.
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }
}
