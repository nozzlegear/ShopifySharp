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
/// The input fields for configuring delivery for a new market.
/// </summary>
public record MarketDeliveryConfigurationsCreateInput : GraphQLInputObject<MarketDeliveryConfigurationsCreateInput>
{
    /// <summary>
    /// The shipping configuration for the market.
    /// </summary>
    [JsonPropertyName("shipping")]
    public ShippingConfigurationCreateInput? shipping { get; set; } = null;
}