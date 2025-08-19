#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The text fields customizations.
/// </summary>
public record CheckoutBrandingTextField : IGraphQLObject
{
    /// <summary>
    /// The border used for text fields.
    /// </summary>
    [JsonPropertyName("border")]
    public CheckoutBrandingBorder? border { get; set; } = null;

    /// <summary>
    /// The typography customizations used for text fields.
    /// </summary>
    [JsonPropertyName("typography")]
    public CheckoutBrandingTypographyStyle? typography { get; set; } = null;
}