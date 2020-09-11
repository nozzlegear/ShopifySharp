using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopifySharp
{
    public class RefundDuty
    {
        [JsonProperty("duty_id")]
        public long? DutyId { get; set; }

        [JsonProperty("amount_set")]
        public PriceSet AmountSet { get; set; }
    }
}
