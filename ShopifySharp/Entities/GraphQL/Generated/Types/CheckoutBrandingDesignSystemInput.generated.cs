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
/// The input fields used to update the design system.
/// </summary>
public record CheckoutBrandingDesignSystemInput : GraphQLInputObject<CheckoutBrandingDesignSystemInput>
{
    /// <summary>
    /// The color settings for global colors and color schemes.
    /// </summary>
    [JsonPropertyName("colors")]
    public CheckoutBrandingColorsInput? colors { get; set; } = null;

    /// <summary>
    /// The corner radius variables.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutBrandingCornerRadiusVariablesInput? cornerRadius { get; set; } = null;

    /// <summary>
    /// The typography.
    /// </summary>
    [JsonPropertyName("typography")]
    public CheckoutBrandingTypographyInput? typography { get; set; } = null;
}