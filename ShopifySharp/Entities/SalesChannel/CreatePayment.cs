using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ShopifySharp.Entities.SalesChannel
{
    public partial class CreatePayment
    {
        [JsonProperty("request_details")]
        public RequestDetails RequestDetails { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        [JsonProperty("unique_token")]
        public string UniqueToken { get; set; }
    }

    public partial class RequestDetails
    {
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("accept_language")]
        public string AcceptLanguage { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
    }
}
