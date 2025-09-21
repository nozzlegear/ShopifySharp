#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The header cart link customizations.
/// </summary>
public record CheckoutBrandingHeaderCartLink : IGraphQLObject
{
    /// <summary>
    /// The content type for the header back to cart link in 1-page checkout. Setting
    /// this to image will render the custom image provided using the image field on
    /// the header cart_link object. If no image is provided, the default cart icon will be used.
    /// </summary>
    [JsonPropertyName("contentType")]
    public CheckoutBrandingCartLinkContentType? contentType { get; set; } = null;

    /// <summary>
    /// The image that's used for the header back to cart link in 1-page checkout when the content type is set to image.
    /// </summary>
    [JsonPropertyName("image")]
    public Image? image { get; set; } = null;
}