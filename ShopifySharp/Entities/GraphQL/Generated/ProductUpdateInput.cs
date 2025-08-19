#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for updating a product.
/// </summary>
public record ProductUpdateInput : GraphQLInputObject<ProductUpdateInput>
{
    /// <summary>
    /// The ID of the [category](https://shopify.github.io/product-taxonomy/releases/unstable/?categoryId=sg-4-17-2-17)
    /// that's associated with the product.
    /// </summary>
    [JsonPropertyName("category")]
    public string? category { get; set; } = null;

    /// <summary>
    /// A list of collection IDs to associate with the product.
    /// </summary>
    [JsonPropertyName("collectionsToJoin")]
    public ICollection<string>? collectionsToJoin { get; set; } = null;

    /// <summary>
    /// The collection IDs to disassociate from the product.
    /// </summary>
    [JsonPropertyName("collectionsToLeave")]
    public ICollection<string>? collectionsToLeave { get; set; } = null;

    /// <summary>
    /// Whether to delete metafields whose constraints don't match the product's category.
    /// Can only be used when updating the product's category.
    /// </summary>
    [JsonPropertyName("deleteConflictingConstrainedMetafields")]
    public bool? deleteConflictingConstrainedMetafields { get; set; } = null;

    /// <summary>
    /// The description of the product, with HTML tags.
    /// For example, the description might include bold `<strong></strong>` and italic `<i></i>` text.
    /// </summary>
    [JsonPropertyName("descriptionHtml")]
    public string? descriptionHtml { get; set; } = null;

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
    /// The product's ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The [custom fields](https://shopify.dev/docs/apps/build/custom-data) to associate with the product
    /// for the purposes of adding and storing additional information.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// The [product type](https://help.shopify.com/manual/products/details/product-type)
    /// that merchants define.
    /// </summary>
    [JsonPropertyName("productType")]
    public string? productType { get; set; } = null;

    /// <summary>
    /// Whether a redirect is required after a new handle has been provided.
    /// If `true`, then the old handle is redirected to the new one automatically.
    /// </summary>
    [JsonPropertyName("redirectNewHandle")]
    public bool? redirectNewHandle { get; set; } = null;

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