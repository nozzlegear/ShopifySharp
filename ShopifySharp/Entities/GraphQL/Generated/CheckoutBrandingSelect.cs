#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The selects customizations.
/// </summary>
public record CheckoutBrandingSelect : IGraphQLObject
{
    /// <summary>
    /// The border used for selects.
    /// </summary>
    [JsonPropertyName("border")]
    public CheckoutBrandingBorder? border { get; set; } = null;

    /// <summary>
    /// The typography customizations used for selects.
    /// </summary>
    [JsonPropertyName("typography")]
    public CheckoutBrandingTypographyStyle? typography { get; set; } = null;
}