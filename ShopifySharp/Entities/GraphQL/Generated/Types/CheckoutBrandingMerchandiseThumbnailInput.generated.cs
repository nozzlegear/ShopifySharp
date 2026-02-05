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
/// The input fields used to update the merchandise thumbnails customizations.
/// </summary>
public record CheckoutBrandingMerchandiseThumbnailInput : GraphQLInputObject<CheckoutBrandingMerchandiseThumbnailInput>
{
    /// <summary>
    /// The settings for the merchandise thumbnail badge.
    /// </summary>
    [JsonPropertyName("badge")]
    public CheckoutBrandingMerchandiseThumbnailBadgeInput? badge { get; set; } = null;

    /// <summary>
    /// The border used for merchandise thumbnails.
    /// </summary>
    [JsonPropertyName("border")]
    public CheckoutBrandingSimpleBorder? border { get; set; } = null;

    /// <summary>
    /// The corner radius used for merchandise thumbnails.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutBrandingCornerRadius? cornerRadius { get; set; } = null;

    /// <summary>
    /// The property used to customize how the product image fits within merchandise thumbnails.
    /// </summary>
    [JsonPropertyName("fit")]
    public CheckoutBrandingObjectFit? fit { get; set; } = null;
}