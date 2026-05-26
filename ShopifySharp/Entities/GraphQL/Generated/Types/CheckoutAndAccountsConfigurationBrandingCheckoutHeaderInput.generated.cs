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
/// The input fields for customizing the checkout header.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingCheckoutHeaderInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingCheckoutHeaderInput>
{
    /// <summary>
    /// The header alignment.
    /// </summary>
    [JsonPropertyName("alignment")]
    public CheckoutAndAccountsConfigurationBrandingHeaderAlignment? alignment { get; set; } = null;

    /// <summary>
    /// The background style of the header container.
    /// </summary>
    [JsonPropertyName("background")]
    public CheckoutAndAccountsConfigurationBrandingBackground? background { get; set; } = null;

    /// <summary>
    /// The input for cart link customizations for 1-page checkout. This field allows
    /// to customize the cart icon that renders by default on 1-page checkout.
    /// </summary>
    [JsonPropertyName("cartLink")]
    public CheckoutAndAccountsConfigurationBrandingHeaderCartLinkInput? cartLink { get; set; } = null;

    /// <summary>
    /// The colors customizations for the header container.
    /// </summary>
    [JsonPropertyName("colors")]
    public CheckoutAndAccountsConfigurationBrandingColorsInput? colors { get; set; } = null;

    /// <summary>
    /// The divided setting.
    /// </summary>
    [JsonPropertyName("divided")]
    public bool? divided { get; set; } = null;

    /// <summary>
    /// The store logo.
    /// </summary>
    [JsonPropertyName("logo")]
    public CheckoutAndAccountsConfigurationBrandingLogoInput? logo { get; set; } = null;

    /// <summary>
    /// The padding of the header container.
    /// </summary>
    [JsonPropertyName("padding")]
    public CheckoutAndAccountsConfigurationBrandingSpacingKeyword? padding { get; set; } = null;

    /// <summary>
    /// The header position.
    /// </summary>
    [JsonPropertyName("position")]
    public CheckoutAndAccountsConfigurationBrandingHeaderPosition? position { get; set; } = null;
}