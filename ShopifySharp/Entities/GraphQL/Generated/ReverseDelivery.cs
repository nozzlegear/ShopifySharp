#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A reverse delivery is a post-fulfillment object that represents a buyer sending a package to a merchant.
/// For example, a buyer requests a return, and a merchant sends the buyer a shipping label.
/// The reverse delivery contains the context of the items sent back, how they're being sent back
/// (for example, a shipping label), and the current state of the delivery (tracking information).
/// </summary>
public record ReverseDelivery : IGraphQLObject, INode
{
    /// <summary>
    /// The deliverable associated with the reverse delivery.
    /// </summary>
    [JsonPropertyName("deliverable")]
    public ReverseDeliveryDeliverable? deliverable { get; set; } = null;

    /// <summary>
    /// The ID of the reverse delivery.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The reverse delivery line items attached to the reverse delivery.
    /// </summary>
    [JsonPropertyName("reverseDeliveryLineItems")]
    public ReverseDeliveryLineItemConnection? reverseDeliveryLineItems { get; set; } = null;

    /// <summary>
    /// The `ReverseFulfillmentOrder` associated with the reverse delivery.
    /// </summary>
    [JsonPropertyName("reverseFulfillmentOrder")]
    public ReverseFulfillmentOrder? reverseFulfillmentOrder { get; set; } = null;
}