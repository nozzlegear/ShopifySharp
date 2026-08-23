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
/// The input fields for customizing the typography.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingTypographyInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingTypographyInput>
{
    /// <summary>
    /// The font group used for most components such as text, buttons and form controls.
    /// </summary>
    [JsonPropertyName("primary")]
    public CheckoutAndAccountsConfigurationBrandingFontGroupInput? primary { get; set; } = null;

    /// <summary>
    /// The font group used for heading components by default.
    /// </summary>
    [JsonPropertyName("secondary")]
    public CheckoutAndAccountsConfigurationBrandingFontGroupInput? secondary { get; set; } = null;

    /// <summary>
    /// The font size.
    /// </summary>
    [JsonPropertyName("size")]
    public CheckoutAndAccountsConfigurationBrandingFontSizeInput? size { get; set; } = null;
}