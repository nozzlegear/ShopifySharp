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
/// The input fields for customizing the design tokens.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingDesignTokensInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingDesignTokensInput>
{
    /// <summary>
    /// The color customizations for global colors.
    /// </summary>
    [JsonPropertyName("colors")]
    public CheckoutAndAccountsConfigurationBrandingDesignTokensColorsInput? colors { get; set; } = null;

    /// <summary>
    /// The corner radius variables.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutAndAccountsConfigurationBrandingCornerRadiusVariablesInput? cornerRadius { get; set; } = null;

    /// <summary>
    /// The typography.
    /// </summary>
    [JsonPropertyName("typography")]
    public CheckoutAndAccountsConfigurationBrandingTypographyInput? typography { get; set; } = null;
}