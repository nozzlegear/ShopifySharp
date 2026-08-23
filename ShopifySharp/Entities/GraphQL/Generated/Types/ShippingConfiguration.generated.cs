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
/// The shipping configuration attached to a market. Defines the shipping
/// options available when a buyer is resolved to that market.
/// </summary>
public record ShippingConfiguration : IGraphQLObject
{
    /// <summary>
    /// Whether shipping is enabled for this market. When false, customers in this market won't see any shipping options.
    /// </summary>
    [JsonPropertyName("isEnabled")]
    public bool? isEnabled { get; set; } = null;

    /// <summary>
    /// The shipping options configured for this market.
    /// </summary>
    [JsonPropertyName("optionDefinitions")]
    public DeliveryOptionDefinitionConnection? optionDefinitions { get; set; } = null;

    /// <summary>
    /// The number of shipping options in this configuration.
    /// </summary>
    [JsonPropertyName("optionDefinitionsCount")]
    public Count? optionDefinitionsCount { get; set; } = null;
}