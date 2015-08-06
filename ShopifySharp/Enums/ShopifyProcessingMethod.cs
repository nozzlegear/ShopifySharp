using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// The type of payment processing method
    /// </summary>
    public enum ShopifyProcessingMethod
    {
        [JsonProperty("checkout")]
        Checkout,

        [JsonProperty("direct")]
        Direct,

        [JsonProperty("manual")]
        Manual,

        [JsonProperty("offsite")]
        Offsite,

        [JsonProperty("express")]
        Express
    }
}
