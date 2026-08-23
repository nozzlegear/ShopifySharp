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
/// Tracks the progress of an asynchronous shipping label purchase request.
/// </summary>
public record ShippingLabelPurchaseResult : IGraphQLObject, IJobResult, INode
{
    /// <summary>
    /// This indicates if the job is still queued or has been run.
    /// </summary>
    [JsonPropertyName("done")]
    public bool? done { get; set; } = null;

    /// <summary>
    /// Purchase-processing errors for the request. Synchronous validation errors are
    /// returned from the `shippingLabelPurchase` mutation's `userErrors` field instead.
    /// </summary>
    [JsonPropertyName("errors")]
    public ICollection<ShippingLabelPurchaseError>? errors { get; set; } = null;

    /// <summary>
    /// A globally-unique ID that's returned when running an asynchronous mutation.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The shipping labels created by the purchase request. Labels are returned only after successful purchase.
    /// </summary>
    [JsonPropertyName("shippingLabels")]
    public ICollection<ShippingLabel>? shippingLabels { get; set; } = null;

    /// <summary>
    /// The current purchase status. A purchase starts as `PENDING_PURCHASE` and ends as either `PURCHASED` or `PURCHASE_FAILED`.
    /// </summary>
    [JsonPropertyName("status")]
    public ShippingLabelPurchaseResultStatus? status { get; set; } = null;
}