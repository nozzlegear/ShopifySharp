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