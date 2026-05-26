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
/// The input fields for customizing the merchandise thumbnails.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailInput>
{
    /// <summary>
    /// The aspect ratio.
    /// </summary>
    [JsonPropertyName("aspectRatio")]
    public decimal? aspectRatio { get; set; } = null;

    /// <summary>
    /// The merchandise thumbnail badge.
    /// </summary>
    [JsonPropertyName("badge")]
    public CheckoutAndAccountsConfigurationBrandingMerchandiseThumbnailBadgeInput? badge { get; set; } = null;

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