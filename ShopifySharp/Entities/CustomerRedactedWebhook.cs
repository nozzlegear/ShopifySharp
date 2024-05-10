using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp;

/// <summary>
/// Sent via the GDPR customers/redact webhook, indicating that you should purge the customer's data from your systems.
/// </summary>
public class CustomerRedactedWebhook : ShopRedactedWebhook
{
    /// <summary>
    /// The customer who has been redacted.
    /// </summary>
    [JsonProperty("customer")]
    public RedactedCustomer Customer { get; set; }

    /// <summary>
    /// A list of order ids placed by the customer that must also be purged from your systems.
    /// </summary>
    [JsonProperty("orders_to_redact")]
    public IEnumerable<long> OrdersToRedact { get; set; }
}