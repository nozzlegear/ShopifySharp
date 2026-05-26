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
/// The design token customizations allow you to set values that represent specific
/// attributes of your brand like color and font. These attributes are used
/// throughout the user interface. This brings consistency and allows you to easily
/// make broad design changes.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingDesignTokens : IGraphQLObject
{
    /// <summary>
    /// The colors for global colors.
    /// </summary>
    [JsonPropertyName("colors")]
    public CheckoutAndAccountsConfigurationBrandingDesignTokenColors? colors { get; set; } = null;

    /// <summary>
    /// The corner radius variables.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutAndAccountsConfigurationBrandingCornerRadiusVariables? cornerRadius { get; set; } = null;

    /// <summary>
    /// The typography.
    /// </summary>
    [JsonPropertyName("typography")]
    public CheckoutAndAccountsConfigurationBrandingTypography? typography { get; set; } = null;
}