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
/// Return type for `shippingLabelPurchase` mutation.
/// </summary>
public record ShippingLabelPurchasePayload : IGraphQLObject
{
    /// <summary>
    /// The asynchronous purchase result. Query this object to track purchase status,
    /// retrieve purchased shipping labels, or inspect purchase-processing errors.
    /// </summary>
    [JsonPropertyName("shippingLabelPurchaseResult")]
    public ShippingLabelPurchaseResult? shippingLabelPurchaseResult { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ShippingLabelPurchaseUserError>? userErrors { get; set; } = null;
}