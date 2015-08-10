using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// The type of payment processing method
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShopifyProcessingMethod
    {
        [EnumMember(Value = "checkout")]
        Checkout,

        [EnumMember(Value = "direct")]
        Direct,

        [EnumMember(Value = "manual")]
        Manual,

        [EnumMember(Value = "offsite")]
        Offsite,

        [EnumMember(Value = "express")]
        Express,

        [EnumMember(Value = "none")]
        None
    }
}
