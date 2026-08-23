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
/// Delivery configurations for a market. Container type for shipping configuration.
/// </summary>
public record MarketDeliveryConfigurations : IGraphQLObject
{
    /// <summary>
    /// The shipping configuration for this market. Null means the market inherits shipping from its parent.
    /// </summary>
    [JsonPropertyName("shipping")]
    public ShippingConfiguration? shipping { get; set; } = null;
}