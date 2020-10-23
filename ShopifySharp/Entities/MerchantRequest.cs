using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ShopifySharp.Entities
{
    public class MerchantRequest
    {
        /// <summary>
        /// The message returned by the merchant, if any.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// The request options returned by the merchant, if any.
        /// </summary>
        [JsonProperty("request_options")]
        public RequestOptions RequestOptions { get; set; }

        /// <summary>
        /// The kind of request. Valid values: "fulfillment_request", "cancellation_request", or "legacy_fulfill_request".
        /// </summary>
        [JsonProperty("kind")]
        public string Kind { get; set; }
    }
    public partial class RequestOptions
    {
        [JsonProperty("shipping_method")]
        public string ShippingMethod { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }
    }
}