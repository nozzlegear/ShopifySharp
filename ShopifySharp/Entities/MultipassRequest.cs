using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopifySharp
{
    public class MultipassRequest : Customer
    {
        [JsonProperty("tag_string")]
        public string TagString { get; set; }
        [JsonProperty("identifier")]
        public string Identifier { get; set; }
        [JsonProperty("remote_ip")]
        public string RemoteIP { get; set; }
        [JsonProperty("return_to")]
        public string ReturnTo { get; set; }
    }
}
