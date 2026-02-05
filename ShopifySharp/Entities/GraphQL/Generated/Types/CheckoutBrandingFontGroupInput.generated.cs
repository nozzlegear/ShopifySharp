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
/// The input fields used to update a font group. To learn more about updating fonts, refer to the
/// [checkoutBrandingUpsert](https://shopify.dev/api/admin-graphql/unstable/mutations/checkoutBrandingUpsert)
/// mutation and the checkout branding [tutorial](https://shopify.dev/docs/apps/checkout/styling).
/// </summary>
public record CheckoutBrandingFontGroupInput : GraphQLInputObject<CheckoutBrandingFontGroupInput>
{
    /// <summary>
    /// A custom font group.
    /// </summary>
    [JsonPropertyName("customFontGroup")]
    public CheckoutBrandingCustomFontGroupInput? customFontGroup { get; set; } = null;

    /// <summary>
    /// A Shopify font group.
    /// </summary>
    [JsonPropertyName("shopifyFontGroup")]
    public CheckoutBrandingShopifyFontGroupInput? shopifyFontGroup { get; set; } = null;
}