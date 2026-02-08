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
/// Return type for `fulfillmentOrderMerge` mutation.
/// </summary>
public record FulfillmentOrderMergePayload : IGraphQLObject
{
    /// <summary>
    /// The result of the fulfillment order merges.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderMerges")]
    public ICollection<FulfillmentOrderMergeResult>? fulfillmentOrderMerges { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<FulfillmentOrderMergeUserError>? userErrors { get; set; } = null;
}