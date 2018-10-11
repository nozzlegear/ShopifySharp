using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp
{
    /// <summary>
    /// Sent via the GDPR customers/data_request webhook, indicating that a customer has requested all data that you may have stored related to them. It's your responsibility to provide this data to the store owner directly. 
    /// </summary>
    public class CustomerDataRequestWebhook : ShopRedactedWebhook
    {
        /// <summary>
        /// The customer who has been redacted.
        /// </summary>
        [JsonProperty("customer")]
        public RedactedCustomer Customer { get; set; }

        /// <summary>
        /// A list of order ids placed by the customer that they are requesting information on.
        /// </summary>
        [JsonProperty("orders_requested")]
        public IEnumerable<long> OrdersRequested { get; set; }
    }
}