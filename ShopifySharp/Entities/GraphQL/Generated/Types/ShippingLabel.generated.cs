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
/// The optional shipping label for this fulfillment.
/// </summary>
public record ShippingLabel : IGraphQLObject, INode
{
    /// <summary>
    /// Indicates whether the label is cancellable or not.
    /// </summary>
    [JsonPropertyName("cancellable")]
    public bool? cancellable { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The location of the shipping origin. This will be null when the shipping origin is unknown.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// Indicates whether the label was printed or not.
    /// </summary>
    [JsonPropertyName("printed")]
    public bool? printed { get; set; } = null;

    /// <summary>
    /// The documents for a shipping label.
    /// </summary>
    [JsonPropertyName("shippingDocuments")]
    public ICollection<ShippingObjectsShippingDocument>? shippingDocuments { get; set; } = null;

    /// <summary>
    /// Tracking information for the shipping label.
    /// </summary>
    [JsonPropertyName("trackingInfo")]
    public FulfillmentTrackingInfo? trackingInfo { get; set; } = null;
}