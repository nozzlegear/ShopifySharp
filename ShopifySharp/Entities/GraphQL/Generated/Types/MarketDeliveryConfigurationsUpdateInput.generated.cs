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
/// The input fields for configuring delivery for an existing market.
/// </summary>
public record MarketDeliveryConfigurationsUpdateInput : GraphQLInputObject<MarketDeliveryConfigurationsUpdateInput>
{
    /// <summary>
    /// When true, removes the shipping configuration so the market inherits shipping from its parent.
    /// </summary>
    [JsonPropertyName("removeShipping")]
    public bool? removeShipping { get; set; } = null;

    /// <summary>
    /// Shipping configuration changes. When omitted, shipping is not changed.
    /// </summary>
    [JsonPropertyName("shipping")]
    public ShippingConfigurationUpdateInput? shipping { get; set; } = null;
}