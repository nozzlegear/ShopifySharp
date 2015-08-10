using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Enums
{
    public enum ShopifyOrderStatus
    {
        [JsonProperty("open")]
        Open,

        [JsonProperty("closed")]
        Closed,

        [JsonProperty("cancelled")]
        Cancelled,

        [JsonProperty("any")]
        Any
    }
}
