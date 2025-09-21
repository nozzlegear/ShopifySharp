#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields used to update a Shopify font group.
/// </summary>
public record CheckoutBrandingShopifyFontGroupInput : GraphQLInputObject<CheckoutBrandingShopifyFontGroupInput>
{
    /// <summary>
    /// The base font weight.
    /// </summary>
    [JsonPropertyName("baseWeight")]
    public int? baseWeight { get; set; } = null;

    /// <summary>
    /// The bold font weight.
    /// </summary>
    [JsonPropertyName("boldWeight")]
    public int? boldWeight { get; set; } = null;

    /// <summary>
    /// The font loading strategy.
    /// </summary>
    [JsonPropertyName("loadingStrategy")]
    public CheckoutBrandingFontLoadingStrategy? loadingStrategy { get; set; } = null;

    /// <summary>
    /// The Shopify font name from [the list of available fonts](https://shopify.dev/themes/architecture/settings/fonts#available-fonts),
    /// such as `Alegreya Sans` or `Anonymous Pro`.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}