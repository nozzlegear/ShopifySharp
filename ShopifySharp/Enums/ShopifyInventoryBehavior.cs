using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ShopifySharp.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
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
