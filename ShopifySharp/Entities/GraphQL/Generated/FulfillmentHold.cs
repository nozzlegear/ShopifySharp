#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A fulfillment hold currently applied on a fulfillment order.
/// </summary>
public record FulfillmentHold : IGraphQLObject, INode
{
    /// <summary>
    /// The localized reason for the fulfillment hold for display purposes.
    /// </summary>
    [JsonPropertyName("displayReason")]
    public string? displayReason { get; set; } = null;

    /// <summary>
    /// An identifier an app can use to reference one of many holds it applied to a fulfillment order.
    /// This field must be unique among the holds that a single app applies to a single fulfillment order.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// The app that created the fulfillment hold.
    /// </summary>
    [JsonPropertyName("heldByApp")]
    public App? heldByApp { get; set; } = null;

    /// <summary>
    /// A boolean value that indicates whether the requesting app created the fulfillment hold.
    /// </summary>
    [JsonPropertyName("heldByRequestingApp")]
    public bool? heldByRequestingApp { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The reason for the fulfillment hold.
    /// </summary>
    [JsonPropertyName("reason")]
    public FulfillmentHoldReason? reason { get; set; } = null;

    /// <summary>
    /// Additional information about the fulfillment hold reason.
    /// </summary>
    [JsonPropertyName("reasonNotes")]
    public string? reasonNotes { get; set; } = null;
}