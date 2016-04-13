using Newtonsoft.Json;
using ShopifySharp.Converters;
using System.Runtime.Serialization;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// An enum that indicates the status of <see cref="ShopifyCharge"/> and <see cref="ShopifyRecurringCharge"/> objects.
    /// </summary>
    [JsonConverter(typeof(NullableEnumConverter<ShopifyChargeStatus>))]
    public enum ShopifyChargeStatus
    {
        /// <summary>
        /// The charge is pending and has not been accepted or declined by the user.
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,

        /// <summary>
        /// The charge has been accepted by the user and can be activated.
        /// </summary>
        [EnumMember(Value = "accepted")]
        Accepted,

        /// <summary>
        /// The charge has been accepted and activated.
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// The charge has been cancelled.
        /// </summary>
        [EnumMember(Value = "cancelled")]
        Cancelled,

        /// <summary>
        /// The charge has been declined by the user and cannot be activated.
        /// </summary>
        [EnumMember(Value = "declined")]
        Declined,

        /// <summary>
        /// The charge has expired.
        /// </summary>
        [EnumMember(Value = "expired")]
        Expired,

    }
}
