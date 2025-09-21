#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The heading level customizations.
/// </summary>
public record CheckoutBrandingHeadingLevel : IGraphQLObject
{
    /// <summary>
    /// The typography customizations used for headings.
    /// </summary>
    [JsonPropertyName("typography")]
    public CheckoutBrandingTypographyStyle? typography { get; set; } = null;
}