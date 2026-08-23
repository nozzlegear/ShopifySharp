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
/// The input fields for customizing the checkout footer.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingCheckoutFooterInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingCheckoutFooterInput>
{
    /// <summary>
    /// The footer alignment settings. You can set the footer native content alignment to the left, center, or right.
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
    public CheckoutAndAccountsConfigurationBrandingColorsInput? colors { get; set; } = null;

    /// <summary>
    /// The input field for setting the footer content customizations.
    /// </summary>
    [JsonPropertyName("content")]
    public CheckoutAndAccountsConfigurationBrandingFooterContentInput? content { get; set; } = null;

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

    /// <summary>
    /// The footer position.
    /// </summary>
    [JsonPropertyName("position")]
    public CheckoutAndAccountsConfigurationBrandingFooterPosition? position { get; set; } = null;
}