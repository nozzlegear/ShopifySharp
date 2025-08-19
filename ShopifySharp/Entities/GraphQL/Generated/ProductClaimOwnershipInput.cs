#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to claim ownership for Product features such as Bundles.
/// </summary>
public record ProductClaimOwnershipInput : GraphQLInputObject<ProductClaimOwnershipInput>
{
    /// <summary>
    /// Claiming ownership of bundles lets the app render a custom UI for the bundles' card on the
    /// products details page in the Shopify admin.
    /// Bundle ownership can only be claimed when creating the product. If you create `ProductVariantComponents`
    /// in any of its product variants, then the bundle ownership is automatically assigned to the app making the call.
    /// [Learn more](https://shopify.dev/docs/apps/selling-strategies/bundles/product-config).
    /// </summary>
    [JsonPropertyName("bundles")]
    public bool? bundles { get; set; } = null;
}