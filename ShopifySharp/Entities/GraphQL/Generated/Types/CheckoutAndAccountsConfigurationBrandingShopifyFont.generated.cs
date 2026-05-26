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
/// The Shopify font customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingShopifyFont : IGraphQLObject
{
    /// <summary>
    /// The font sources.
    /// </summary>
    [JsonPropertyName("sources")]
    public string? sources { get; set; } = null;

    /// <summary>
    /// The font weight.
    /// </summary>
    [JsonPropertyName("weight")]
    public int? weight { get; set; } = null;
}