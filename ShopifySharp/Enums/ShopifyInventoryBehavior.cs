using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Enums
{
    public enum ShopifyInventoryBehavior
    {
        /// <summary>
        /// Do not claim inventory. Default.
        /// </summary>
        [JsonProperty("bypass")]
        Bypass,

        /// <summary>
        /// Ignore the product's inventory policy and claim amounts no matter what.
        /// </summary>
        [JsonProperty("decrement_ignoring_policy")]
        DecrementIgnoringPolicy,

        /// <summary>
        /// Obey the product's inventory policy.
        /// </summary>
        [JsonProperty("decrement_obeying_policy")]
        DecrementObeyingPolicy
    }
}
