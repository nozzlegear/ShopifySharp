using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyError
    {
        [JsonProperty("errors")]
        public string Errors { get; set; }
    }
}
