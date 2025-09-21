#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to create a product.
/// </summary>
public record ProductCreateInput : GraphQLInputObject<ProductCreateInput>
{
    /// <summary>
    /// The ID of the [category](https://shopify.github.io/product-taxonomy/releases/unstable/?categoryId=sg-4-17-2-17)
    /// that's associated with the product.
    /// </summary>
    [JsonPropertyName("category")]
    public string? category { get; set; } = null;

    /// <summary>
    /// The input field to enable an app to provide additional product features.
    /// For example, you can specify
    /// [`bundles: true`](https://shopify.dev/docs/api/admin-graphql/latest/input-objects/ProductClaimOwnershipInput#field-bundles)
    /// in the `claimOwnership` field to let an app add a
    /// [product configuration extension](https://shopify.dev/docs/apps/build/product-merchandising/bundles/product-configuration-extension/add-merchant-config-ui).
    /// </summary>
    [JsonPropertyName("claimOwnership")]
    public ProductClaimOwnershipInput? claimOwnership { get; set; } = null;

    /// <summary>
    /// A list of collection IDs to associate with the product.
    /// </summary>
    [JsonPropertyName("collectionsToJoin")]
    public ICollection<string>? collectionsToJoin { get; set; } = null;

    /// <summary>
    /// The role of the product in a [combined listing](https://shopify.dev/apps/build/product-merchandising/combined-listings).
    /// </summary>
    [JsonPropertyName("combinedListingRole")]
    public CombinedListingsRole? combinedListingRole { get; set; } = null;

    /// <summary>
    /// The description of the product, with HTML tags.
    /// For example, the description might include bold `<strong></strong>` and italic `<i></i>` text.
    /// </summary>
    [JsonPropertyName("descriptionHtml")]
    public string? descriptionHtml { get; set; } = null;

    /// <summary>
    /// Whether the product is a gift card.
    /// </summary>
    [JsonPropertyName("giftCard")]
    public bool? giftCard { get; set; } = null;

    /// <summary>
    /// The [theme template](https://shopify.dev/docs/storefronts/themes/architecture/templates)
    /// that's used when customers view a gift card in a store.
    /// </summary>
    [JsonPropertyName("giftCardTemplateSuffix")]
    public string? giftCardTemplateSuffix { get; set; } = null;

    /// <summary>
    /// A unique, human-readable string that's used to identify the product in URLs. A
    /// handle can contain letters, hyphens (`-`), and numbers, but no spaces.
    /// If no handle is explicitly provided, then the title is used to construct the product's handle.
    /// For example, if a product is titled "Black Sunglasses" and no handle is
    /// provided, then the handle `black-sunglasses` is generated (unless that handle
    /// is already taken, in which case a suffix is added to make the handle unique).
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// The [custom fields](https://shopify.dev/docs/apps/build/custom-data) to associate with the product
    /// for the purposes of adding and storing additional information.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// A list of product options and option values. Maximum product options: three.
    /// There's no limit on the number of option values.
    /// </summary>
    [JsonPropertyName("productOptions")]
    public ICollection<OptionCreateInput>? productOptions { get; set; } = null;

    /// <summary>
    /// The [product type](https://help.shopify.com/manual/products/details/product-type)
    /// that merchants define.
    /// </summary>
    [JsonPropertyName("productType")]
    public string? productType { get; set; } = null;

    /// <summary>
    /// Whether the product can only be purchased with
    /// a [selling plan](https://shopify.dev/docs/apps/build/purchase-options/subscriptions/selling-plans).
    /// Products that are sold on subscription (`requiresSellingPlan: true`) can be updated only for online stores.
    /// If you update a product to be subscription-only (`requiresSellingPlan:false`),
    /// then the product is unpublished from all channels except the online store.
    /// </summary>
    [JsonPropertyName("requiresSellingPlan")]
    public bool? requiresSellingPlan { get; set; } = null;

    /// <summary>
    /// The [SEO title and description](https://help.shopify.com/manual/promoting-marketing/seo/adding-keywords)
    /// that are associated with a product.
    /// </summary>
    [JsonPropertyName("seo")]
    public SEOInput? seo { get; set; } = null;

    /// <summary>
    /// The [product status](https://help.shopify.com/manual/products/details/product-details-page#product-status),
    /// which controls visibility across all sales channels.
    /// </summary>
    [JsonPropertyName("status")]
    public ProductStatus? status { get; set; } = null;

    /// <summary>
    /// A list of searchable keywords that are
    /// associated with the product. For example, a merchant might apply the `sports`
    /// and `summer` tags to products that are associated with sportwear for summer.
    /// Updating `tags` overwrites any existing tags that were previously added to the product.
    /// To add new tags without overwriting existing tags, use the
    /// [`tagsAdd`](https://shopify.dev/api/admin-graphql/latest/mutations/tagsadd)
    /// mutation.
    /// </summary>
    [JsonPropertyName("tags")]
    public ICollection<string>? tags { get; set; } = null;

    /// <summary>
    /// The [theme template](https://shopify.dev/docs/storefronts/themes/architecture/templates)
    /// that's used when customers view a product in a store.
    /// </summary>
    [JsonPropertyName("templateSuffix")]
    public string? templateSuffix { get; set; } = null;

    /// <summary>
    /// The name for the product that displays to customers. If no handle is
    /// explicitly provided, then the title is used to construct the product's handle.
    /// For example, if a product is titled "Black Sunglasses" and no handle is
    /// provided, then the handle `black-sunglasses` is generated.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The name of the product's vendor.
    /// </summary>
    [JsonPropertyName("vendor")]
    public string? vendor { get; set; } = null;
}