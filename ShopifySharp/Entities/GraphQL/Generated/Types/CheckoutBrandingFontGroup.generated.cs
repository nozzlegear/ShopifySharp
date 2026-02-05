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
/// A font group. To learn more about updating fonts, refer to the
/// [checkoutBrandingUpsert](https://shopify.dev/api/admin-graphql/unstable/mutations/checkoutBrandingUpsert)
/// mutation and the checkout branding [tutorial](https://shopify.dev/docs/apps/checkout/styling).
/// </summary>
public record CheckoutBrandingFontGroup : IGraphQLObject
{
    /// <summary>
    /// The base font.
    /// </summary>
    [JsonPropertyName("base")]
    public ICheckoutBrandingFont? @base { get; set; } = null;

    /// <summary>
    /// The bold font.
    /// </summary>
    [JsonPropertyName("bold")]
    public ICheckoutBrandingFont? bold { get; set; } = null;

    /// <summary>
    /// The font loading strategy.
    /// </summary>
    [JsonPropertyName("loadingStrategy")]
    public CheckoutBrandingFontLoadingStrategy? loadingStrategy { get; set; } = null;

    /// <summary>
    /// The font group name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}