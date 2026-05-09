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
/// The input fields for customizing the merchandise thumbnail badges.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadgeInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadgeInput>
{
    /// <summary>
    /// The background.
    /// </summary>
    [JsonPropertyName("background")]
    public CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadgeBackground? background { get; set; } = null;
}