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
/// The merchandise thumbnails customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnail : IGraphQLObject
{
    /// <summary>
    /// The merchandise thumbnail badge.
    /// </summary>
    [JsonPropertyName("badge")]
    public CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadge? badge { get; set; } = null;

    /// <summary>
    /// The border.
    /// </summary>
    [JsonPropertyName("border")]
    public CheckoutAndAccountsConfigurationBrandingSimpleBorder? border { get; set; } = null;

    /// <summary>
    /// The corner radius.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutAndAccountsConfigurationBrandingCornerRadius? cornerRadius { get; set; } = null;

    /// <summary>
    /// The property used to customize how the product image fits within merchandise thumbnails.
    /// </summary>
    [JsonPropertyName("fit")]
    public CheckoutAndAccountsConfigurationBrandingObjectFit? fit { get; set; } = null;
}