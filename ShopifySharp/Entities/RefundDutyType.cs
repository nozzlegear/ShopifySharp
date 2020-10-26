using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopifySharp
{
    public class RefundDutyType
    {
        [JsonProperty("duty_id")]
        public long? DutyId { get; set; }

        [JsonProperty("refund_type")]
        public string RefundType { get; set; }
    }
}
