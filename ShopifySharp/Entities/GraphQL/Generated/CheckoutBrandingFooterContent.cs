#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The footer content customizations.
/// </summary>
public record CheckoutBrandingFooterContent : IGraphQLObject
{
    /// <summary>
    /// The visibility settings for footer content.
    /// </summary>
    [JsonPropertyName("visibility")]
    public CheckoutBrandingVisibility? visibility { get; set; } = null;
}