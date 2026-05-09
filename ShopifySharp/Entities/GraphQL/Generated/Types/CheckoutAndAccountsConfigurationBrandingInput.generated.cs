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
/// The input fields for customizing Checkout and Customer Accounts branding.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingInput>
{
    /// <summary>
    /// The customizations that apply to specific components or areas of the user interface.
    /// </summary>
    [JsonPropertyName("components")]
    public CheckoutAndAccountsConfigurationBrandingComponentsInput? components { get; set; } = null;

    /// <summary>
    /// The design tokens allows you to set values that represent specific attributes
    /// of your brand like color and font. These attributes are used throughout the
    /// user interface. This brings consistency and allows you to easily make broad
    /// design changes.
    /// </summary>
    [JsonPropertyName("designTokens")]
    public CheckoutAndAccountsConfigurationBrandingDesignTokensInput? designTokens { get; set; } = null;

    /// <summary>
    /// The surface-level customizations.
    /// </summary>
    [JsonPropertyName("surfaces")]
    public CheckoutAndAccountsConfigurationBrandingSurfacesInput? surfaces { get; set; } = null;
}