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
/// Return type for `fulfillmentOrderSplit` mutation.
/// </summary>
public record FulfillmentOrderSplitPayload : IGraphQLObject
{
    /// <summary>
    /// The result of the fulfillment order splits.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderSplits")]
    public ICollection<FulfillmentOrderSplitResult>? fulfillmentOrderSplits { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<FulfillmentOrderSplitUserError>? userErrors { get; set; } = null;
}