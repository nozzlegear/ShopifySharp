#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The merchandise thumbnail badges customizations.
/// </summary>
public record CheckoutBrandingMerchandiseThumbnailBadge : IGraphQLObject
{
    /// <summary>
    /// The background used for merchandise thumbnail badges.
    /// </summary>
    [JsonPropertyName("background")]
    public CheckoutBrandingMerchandiseThumbnailBadgeBackground? background { get; set; } = null;
}