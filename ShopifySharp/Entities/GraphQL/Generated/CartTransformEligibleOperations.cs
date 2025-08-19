#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the cart transform feature configuration for the shop.
/// </summary>
public record CartTransformEligibleOperations : IGraphQLObject
{
    /// <summary>
    /// The shop is eligible for expand operations.
    /// </summary>
    [JsonPropertyName("expandOperation")]
    public bool? expandOperation { get; set; } = null;

    /// <summary>
    /// The shop is eligible for merge operations.
    /// </summary>
    [JsonPropertyName("mergeOperation")]
    public bool? mergeOperation { get; set; } = null;

    /// <summary>
    /// The shop is eligible for update operations.
    /// </summary>
    [JsonPropertyName("updateOperation")]
    public bool? updateOperation { get; set; } = null;
}