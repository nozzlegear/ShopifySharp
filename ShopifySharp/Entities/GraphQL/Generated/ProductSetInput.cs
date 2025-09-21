#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to create or update a product via ProductSet mutation.
/// </summary>
public record ProductSetInput : GraphQLInputObject<ProductSetInput>
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
    /// The IDs of collections that this product will be a member of.
    /// </summary>
    [JsonPropertyName("collections")]
    public ICollection<string>? collections { get; set; } = null;

    /// <summary>
    /// The role of the product in a product grouping. It can only be set during creation.
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
    /// The files to associate with the product.
    /// </summary>
    [JsonPropertyName("files")]
    public ICollection<FileSetInput>? files { get; set; } = null;

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
    /// The metafields to associate with this product.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// List of custom product options and option values (maximum of 3 per product).
    /// </summary>
    [JsonPropertyName("productOptions")]
    public ICollection<OptionSetInput>? productOptions { get; set; } = null;

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
    /// Whether the product can only be purchased with a selling plan (subscription).
    /// Products that are sold exclusively on subscription can only be created on
    /// online stores. If set to `true` on an already existing product, then the
    /// product will be marked unavailable on channels that don't support subscriptions.
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
    /// The status of the product.
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
    /// A list of variants associated with the product.
    /// </summary>
    [JsonPropertyName("variants")]
    public ICollection<ProductVariantSetInput>? variants { get; set; } = null;

    /// <summary>
    /// The name of the product's vendor.
    /// </summary>
    [JsonPropertyName("vendor")]
    public string? vendor { get; set; } = null;
}