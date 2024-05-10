using Newtonsoft.Json;
using System.Collections.Generic;

namespace ShopifySharp;

/// <summary>
/// An object representing Shopify fulfillment shipping options.
/// </summary>
public class FulfillmentShipping
{
    /// <summary>
    /// An optional message for the fulfillment request.
    /// </summary>
    [JsonProperty("message")]
    public string Message { get; set; }

    /// <summary>
    /// A flag indicating whether the customer should be notified. If set to true, an email will be
    /// sent when the fulfillment is created or updated. The default value is false for fulfillments
    /// on any orders created initially through the API. For all other orders, the default value is true.
    /// </summary>
    [JsonProperty("notify_customer")]
    public bool? NotifyCustomer { get; set; }

    /// <summary>
    /// If applicable tracking details for the package.
    /// </summary>
    [JsonProperty("tracking_info")]
    public TrackingInfo TrackingInfo { get; set; }

    /// <summary>
    /// The address of the fulfillment location.
    /// </summary>
    [JsonProperty("origin_address")]
    public FulfillmentOriginAddress OriginAddress { get; set; }

    /// <summary>
    /// The fulfillment order line items that have to be fulfilled.
    /// </summary>
    [JsonProperty("line_items_by_fulfillment_order")]
    public IEnumerable<LineItemsByFulfillmentOrder> FulfillmentRequestOrderLineItems { get; set; }
}