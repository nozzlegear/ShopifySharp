#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to update the global typography customizations.
/// </summary>
public record CheckoutBrandingTypographyStyleGlobalInput : GraphQLInputObject<CheckoutBrandingTypographyStyleGlobalInput>
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