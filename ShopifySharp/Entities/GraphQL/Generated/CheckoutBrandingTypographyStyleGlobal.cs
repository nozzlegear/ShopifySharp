#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The global typography customizations.
/// </summary>
public record CheckoutBrandingTypographyStyleGlobal : IGraphQLObject
{
    /// <summary>
    /// The kerning.
    /// </summary>
    [JsonPropertyName("kerning")]
    public CheckoutBrandingTypographyKerning? kerning { get; set; } = null;

    /// <summary>
    /// The letter case.
    /// </summary>
    [JsonPropertyName("letterCase")]
    public CheckoutBrandingTypographyLetterCase? letterCase { get; set; } = null;
}