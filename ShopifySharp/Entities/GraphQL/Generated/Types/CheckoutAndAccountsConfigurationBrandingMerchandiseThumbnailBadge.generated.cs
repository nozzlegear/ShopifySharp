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
public record CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadge : IGraphQLObject
{
    /// <summary>
    /// The background.
    /// </summary>
    [JsonPropertyName("background")]
    public CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadgeBackground? background { get; set; } = null;
}