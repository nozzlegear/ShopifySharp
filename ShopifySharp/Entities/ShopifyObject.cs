using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public abstract class ShopifyObject
    {
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
