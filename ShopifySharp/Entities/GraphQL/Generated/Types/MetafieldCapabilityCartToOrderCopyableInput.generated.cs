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
/// The input fields for enabling or disabling the "Cart to order copyable" capability.
/// This capability is only available for order metafield definitions.
/// When enabled, the value from a cart metafield is automatically copied to the corresponding
/// order metafield when an order is created. The namespace and key must match between the cart and order metafields.
/// </summary>
public record MetafieldCapabilityCartToOrderCopyableInput : GraphQLInputObject<MetafieldCapabilityCartToOrderCopyableInput>
{
    /// <summary>
    /// Indicates whether the capability should be enabled or disabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;
}