using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ShopifySharp.Entities.SalesChannel
{
    public class CardVault
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
