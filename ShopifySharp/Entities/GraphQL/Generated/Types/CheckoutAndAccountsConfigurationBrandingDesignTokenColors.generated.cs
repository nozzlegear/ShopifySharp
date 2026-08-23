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
/// The color customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingDesignTokenColors : IGraphQLObject
{
    /// <summary>
    /// A set of colors used together on a surface.
    /// </summary>
    [JsonPropertyName("palette")]
    public CheckoutAndAccountsConfigurationBrandingPalette? palette { get; set; } = null;
}