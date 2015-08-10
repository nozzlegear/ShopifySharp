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
    public enum ShopifyOrderStatus
    {
        [EnumMember(Value = "open")]
        Open,

        [EnumMember(Value = "closed")]
        Closed,

        [EnumMember(Value = "cancelled")]
        Cancelled,

        [EnumMember(Value = "any")]
        Any
    }
}
