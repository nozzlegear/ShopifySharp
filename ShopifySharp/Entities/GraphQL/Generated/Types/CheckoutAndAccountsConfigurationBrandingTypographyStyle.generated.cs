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
/// The typography customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingTypographyStyle : IGraphQLObject
{
    /// <summary>
    /// The font.
    /// </summary>
    [JsonPropertyName("font")]
    public CheckoutAndAccountsConfigurationBrandingTypographyFont? font { get; set; } = null;

    /// <summary>
    /// The kerning.
    /// </summary>
    [JsonPropertyName("kerning")]
    public CheckoutAndAccountsConfigurationBrandingTypographyKerning? kerning { get; set; } = null;

    /// <summary>
    /// The letter case.
    /// </summary>
    [JsonPropertyName("letterCase")]
    public CheckoutAndAccountsConfigurationBrandingTypographyLetterCase? letterCase { get; set; } = null;

    /// <summary>
    /// The font size.
    /// </summary>
    [JsonPropertyName("size")]
    public CheckoutAndAccountsConfigurationBrandingTypographySize? size { get; set; } = null;

    /// <summary>
    /// The font weight.
    /// </summary>
    [JsonPropertyName("weight")]
    public CheckoutAndAccountsConfigurationBrandingTypographyWeight? weight { get; set; } = null;
}