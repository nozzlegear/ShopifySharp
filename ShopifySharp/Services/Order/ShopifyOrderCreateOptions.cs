using Newtonsoft.Json;
using ShopifySharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyOrderCreateOptions : Parameterizable
    {
        [JsonProperty("send_webhooks")]
        public bool? SendWebhooks { get; set; }

        [JsonProperty("send_receipt")]
        public bool? SendReceipt { get; set; }

        [JsonProperty("send_fulfillment_receipt")]
        public bool? SendFulfillmentReceipt { get; set; }

        [JsonProperty("inventory_behavior")]
        public ShopifyInventoryBehavior? InventoryBehavior {get; set;}
    }
}
