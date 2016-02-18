using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyPageCreateOptions : Parameterizable
    {

        [JsonProperty("published")]
        public bool? Published { get; set; }

    }
}
