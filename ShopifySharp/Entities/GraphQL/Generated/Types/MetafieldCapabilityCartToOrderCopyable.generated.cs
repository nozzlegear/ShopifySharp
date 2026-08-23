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
/// Information about the cart to order copyable capability on a metafield definition.
/// Only order metafield definitions are eligible to have this capability enabled.
/// When enabled, the value from a cart metafield is automatically copied to the corresponding
/// order metafield when an order is created. The namespace and key must match between the cart and order metafields.
/// </summary>
public record MetafieldCapabilityCartToOrderCopyable : IGraphQLObject
{
    /// <summary>
    /// Indicates if the definition is eligible to have the capability.
    /// </summary>
    [JsonPropertyName("eligible")]
    public bool? eligible { get; set; } = null;

    /// <summary>
    /// Indicates if the capability is enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;
}