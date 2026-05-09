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
/// The input fields for customizing the shared settings.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingSharedInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingSharedInput>
{
    /// <summary>
    /// The shared color customizations.
    /// </summary>
    [JsonPropertyName("colors")]
    public CheckoutAndAccountsConfigurationBrandingSharedColorsInput? colors { get; set; } = null;

    /// <summary>
    /// Select a shared corner radius setting that overrides all other corner radii customizations.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutAndAccountsConfigurationBrandingSharedCornerRadius? cornerRadius { get; set; } = null;

    /// <summary>
    /// The shared typography customizations.
    /// </summary>
    [JsonPropertyName("typography")]
    public CheckoutAndAccountsConfigurationBrandingSharedTypographyStyleInput? typography { get; set; } = null;
}