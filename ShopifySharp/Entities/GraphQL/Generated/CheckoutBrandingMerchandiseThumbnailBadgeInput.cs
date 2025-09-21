#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields used to update the merchandise thumbnail badges customizations.
/// </summary>
public record CheckoutBrandingMerchandiseThumbnailBadgeInput : GraphQLInputObject<CheckoutBrandingMerchandiseThumbnailBadgeInput>
{
    /// <summary>
    /// The background used for merchandise thumbnail badges.
    /// </summary>
    [JsonPropertyName("background")]
    public CheckoutBrandingMerchandiseThumbnailBadgeBackground? background { get; set; } = null;
}