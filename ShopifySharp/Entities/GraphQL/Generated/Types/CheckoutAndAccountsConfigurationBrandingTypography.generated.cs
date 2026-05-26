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
/// The typography customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingTypography : IGraphQLObject
{
    /// <summary>
    /// The font group used for most components such as text, buttons and form controls.
    /// </summary>
    [JsonPropertyName("primary")]
    public CheckoutAndAccountsConfigurationBrandingFontGroup? primary { get; set; } = null;

    /// <summary>
    /// The font group used for heading components by default.
    /// </summary>
    [JsonPropertyName("secondary")]
    public CheckoutAndAccountsConfigurationBrandingFontGroup? secondary { get; set; } = null;

    /// <summary>
    /// The font size (base size in pixels and scaling between different sizes).
    /// </summary>
    [JsonPropertyName("size")]
    public CheckoutAndAccountsConfigurationBrandingFontSize? size { get; set; } = null;
}