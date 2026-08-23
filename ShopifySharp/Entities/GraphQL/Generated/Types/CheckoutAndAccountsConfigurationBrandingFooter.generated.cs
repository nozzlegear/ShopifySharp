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
/// A container for the footer section customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingFooter : IGraphQLObject
{
    /// <summary>
    /// The footer alignment.
    /// </summary>
    [JsonPropertyName("alignment")]
    public CheckoutAndAccountsConfigurationBrandingFooterAlignment? alignment { get; set; } = null;

    /// <summary>
    /// The background style of the footer container.
    /// </summary>
    [JsonPropertyName("background")]
    public CheckoutAndAccountsConfigurationBrandingBackground? background { get; set; } = null;

    /// <summary>
    /// The colors customizations.
    /// </summary>
    [JsonPropertyName("colors")]
    public CheckoutAndAccountsConfigurationBrandingColors? colors { get; set; } = null;

    /// <summary>
    /// The footer content settings.
    /// </summary>
    [JsonPropertyName("content")]
    public CheckoutAndAccountsConfigurationBrandingFooterContent? content { get; set; } = null;

    /// <summary>
    /// The divided setting.
    /// </summary>
    [JsonPropertyName("divided")]
    public bool? divided { get; set; } = null;

    /// <summary>
    /// The padding of the footer container.
    /// </summary>
    [JsonPropertyName("padding")]
    public CheckoutAndAccountsConfigurationBrandingSpacingKeyword? padding { get; set; } = null;
}