#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to dispose a reverse fulfillment order line item.
/// </summary>
public record ReverseFulfillmentOrderDisposeInput : GraphQLInputObject<ReverseFulfillmentOrderDisposeInput>
{
    /// <summary>
    /// The final arrangement for the reverse fulfillment order line item.
    /// </summary>
    [JsonPropertyName("dispositionType")]
    public ReverseFulfillmentOrderDispositionType? dispositionType { get; set; } = null;

    /// <summary>
    /// The ID of the location where the reverse fulfillment order line item is to be disposed.
    ///         This is required when the disposition type is RESTOCKED.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? locationId { get; set; } = null;

    /// <summary>
    /// The quantity of the reverse fulfillment order line item to dispose.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The ID of the reverse fulfillment order line item.
    /// </summary>
    [JsonPropertyName("reverseFulfillmentOrderLineItemId")]
    public string? reverseFulfillmentOrderLineItemId { get; set; } = null;
}