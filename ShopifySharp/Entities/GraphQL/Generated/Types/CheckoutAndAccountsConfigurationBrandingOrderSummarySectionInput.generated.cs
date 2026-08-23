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
/// The input fields for customizing the order summary sections.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingOrderSummarySectionInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingOrderSummarySectionInput>
{
    /// <summary>
    /// The background style of the order summary sections.
    /// </summary>
    [JsonPropertyName("background")]
    public CheckoutAndAccountsConfigurationBrandingBackground? background { get; set; } = null;

    /// <summary>
    /// The border for the order summary sections.
    /// </summary>
    [JsonPropertyName("border")]
    public CheckoutAndAccountsConfigurationBrandingSimpleBorder? border { get; set; } = null;

    /// <summary>
    /// The border style of the order summary sections.
    /// </summary>
    [JsonPropertyName("borderStyle")]
    public CheckoutAndAccountsConfigurationBrandingBorderStyle? borderStyle { get; set; } = null;

    /// <summary>
    /// The border width of the order summary sections.
    /// </summary>
    [JsonPropertyName("borderWidth")]
    public CheckoutAndAccountsConfigurationBrandingBorderWidth? borderWidth { get; set; } = null;

    /// <summary>
    /// The colors customizations.
    /// </summary>
    [JsonPropertyName("colors")]
    public CheckoutAndAccountsConfigurationBrandingColorsInput? colors { get; set; } = null;

    /// <summary>
    /// The corner radius of the order summary sections.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutAndAccountsConfigurationBrandingCornerRadius? cornerRadius { get; set; } = null;

    /// <summary>
    /// The padding of the order summary sections.
    /// </summary>
    [JsonPropertyName("padding")]
    public CheckoutAndAccountsConfigurationBrandingSpacingKeyword? padding { get; set; } = null;

    /// <summary>
    /// The shadow of the order summary sections.
    /// </summary>
    [JsonPropertyName("shadow")]
    public CheckoutAndAccountsConfigurationBrandingShadow? shadow { get; set; } = null;
}