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
/// A set of colors used together on a surface.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingPalette : IGraphQLObject
{
    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color1")]
    public string? color1 { get; set; } = null;

    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color10")]
    public string? color10 { get; set; } = null;

    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color11")]
    public string? color11 { get; set; } = null;

    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color12")]
    public string? color12 { get; set; } = null;

    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color13")]
    public string? color13 { get; set; } = null;

    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color14")]
    public string? color14 { get; set; } = null;

    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color15")]
    public string? color15 { get; set; } = null;

    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color16")]
    public string? color16 { get; set; } = null;

    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color17")]
    public string? color17 { get; set; } = null;

    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color18")]
    public string? color18 { get; set; } = null;

    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color19")]
    public string? color19 { get; set; } = null;

    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color2")]
    public string? color2 { get; set; } = null;

    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color20")]
    public string? color20 { get; set; } = null;

    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color3")]
    public string? color3 { get; set; } = null;

    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color4")]
    public string? color4 { get; set; } = null;

    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color5")]
    public string? color5 { get; set; } = null;

    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color6")]
    public string? color6 { get; set; } = null;

    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color7")]
    public string? color7 { get; set; } = null;

    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color8")]
    public string? color8 { get; set; } = null;

    /// <summary>
    /// A color in the palette (hex value).
    /// </summary>
    [JsonPropertyName("color9")]
    public string? color9 { get; set; } = null;
}