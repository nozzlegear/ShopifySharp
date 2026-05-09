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
/// The branding configuration for checkout and customer accounts.
/// </summary>
public record CheckoutAndAccountsConfigurationBranding : IGraphQLObject
{
    /// <summary>
    /// The components that apply to all surfaces.
    /// </summary>
    [JsonPropertyName("components")]
    public CheckoutAndAccountsConfigurationBrandingComponents? components { get; set; } = null;

    /// <summary>
    /// The design tokens allow you to set values that represent specific attributes
    /// of your brand like color and font. These attributes are used throughout the
    /// user interface. This brings consistency and allows you to easily make broad
    /// design changes.
    /// </summary>
    [JsonPropertyName("designTokens")]
    public CheckoutAndAccountsConfigurationBrandingDesignTokens? designTokens { get; set; } = null;

    /// <summary>
    /// The surface-specific customizations.
    /// </summary>
    [JsonPropertyName("surfaces")]
    public CheckoutAndAccountsConfigurationBrandingSurfaces? surfaces { get; set; } = null;
}