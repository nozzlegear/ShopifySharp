using Newtonsoft.Json;
using ShopifySharp.Converters;
using System.Runtime.Serialization;

namespace ShopifySharp.Enums
{
    [JsonConverter(typeof(NullableEnumConverter<ShopifyInventoryBehavior>))]
    public enum ShopifyInventoryBehavior
    {
        /// <summary>
        /// Do not claim inventory. Default.
        /// </summary>
        [EnumMember(Value = "bypass")]
        Bypass,

        /// <summary>
        /// Ignore the product's inventory policy and claim amounts no matter what.
        /// </summary>
        [EnumMember(Value = "decrement_ignoring_policy")]
        DecrementIgnoringPolicy,

        /// <summary>
        /// Obey the product's inventory policy.
        /// </summary>
        [EnumMember(Value = "decrement_obeying_policy")]
        DecrementObeyingPolicy
    }
}
