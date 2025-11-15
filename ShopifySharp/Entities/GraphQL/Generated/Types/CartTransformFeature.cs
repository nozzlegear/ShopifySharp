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
/// Represents the cart transform feature configuration for the shop.
/// </summary>
public record CartTransformFeature : IGraphQLObject
{
    /// <summary>
    /// The cart transform operations eligible for the shop.
    /// </summary>
    [JsonPropertyName("eligibleOperations")]
    public CartTransformEligibleOperations? eligibleOperations { get; set; } = null;
}