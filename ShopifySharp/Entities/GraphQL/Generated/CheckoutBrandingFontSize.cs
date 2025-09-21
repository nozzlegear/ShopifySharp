#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The font size.
/// </summary>
public record CheckoutBrandingFontSize : IGraphQLObject
{
    /// <summary>
    /// The base font size.
    /// </summary>
    [JsonPropertyName("base")]
    public decimal? @base { get; set; } = null;

    /// <summary>
    /// The scale ratio used to derive all font sizes such as small and large.
    /// </summary>
    [JsonPropertyName("ratio")]
    public decimal? ratio { get; set; } = null;
}