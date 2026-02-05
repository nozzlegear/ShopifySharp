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
/// The design system allows you to set values that represent specific attributes
/// of your brand like color and font. These attributes are used throughout the user
/// interface. This brings consistency and allows you to easily make broad design changes.
/// </summary>
public record CheckoutBrandingDesignSystem : IGraphQLObject
{
    /// <summary>
    /// The color settings for global colors and color schemes.
    /// </summary>
    [JsonPropertyName("colors")]
    public CheckoutBrandingColors? colors { get; set; } = null;

    /// <summary>
    /// The corner radius variables.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutBrandingCornerRadiusVariables? cornerRadius { get; set; } = null;

    /// <summary>
    /// The typography.
    /// </summary>
    [JsonPropertyName("typography")]
    public CheckoutBrandingTypography? typography { get; set; } = null;
}