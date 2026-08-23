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
/// The input fields for creating a market's shipping configuration.
/// </summary>
public record ShippingConfigurationCreateInput : GraphQLInputObject<ShippingConfigurationCreateInput>
{
    /// <summary>
    /// Whether shipping is enabled for this market. When false, customers in this market won't see shipping options at checkout.
    /// </summary>
    [JsonPropertyName("isEnabled")]
    public bool? isEnabled { get; set; } = null;

    /// <summary>
    /// Shipping options to create for the market.
    /// </summary>
    [JsonPropertyName("optionDefinitions")]
    public ICollection<DeliveryOptionDefinitionCreateInput>? optionDefinitions { get; set; } = null;
}