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
/// The input fields for creating or updating a gift card product with the
/// [`giftCardProductSet`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/giftCardProductSet)
/// mutation.
/// For list fields like
/// [`variants`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/giftCardProductSet#arguments-input.fields.variants),
/// the mutation creates new entries, updates existing ones, and deletes any entries not included
/// in the input. All other fields update only when explicitly provided, leaving omitted fields
/// unchanged.
/// </summary>
public record GiftCardProductSetInput : GraphQLInputObject<GiftCardProductSetInput>
{
    /// <summary>
    /// The IDs of collections that this product will be a member of.
    /// </summary>
    [JsonPropertyName("collections")]
    public ICollection<string>? collections { get; set; } = null;

    /// <summary>
    /// Whether gift cards fulfilled from this product are redeemable in any payment currency supported by the store.
    /// > Note
    /// > This value can't be changed after the product is created.
    /// </summary>
    [JsonPropertyName("crossCurrencyRedeemable")]
    public bool? crossCurrencyRedeemable { get; set; } = null;

    /// <summary>
    /// The description of the product, with HTML tags.
    /// For example, the description might include bold `<strong></strong>` and italic `<i></i>` text.
    /// </summary>
    [JsonPropertyName("descriptionHtml")]
    public string? descriptionHtml { get; set; } = null;

    /// <summary>
    /// The files to associate with the product.
    /// Complexity cost: 1.9 per file.
    /// </summary>
    [JsonPropertyName("files")]
    public ICollection<FileSetInput>? files { get; set; } = null;

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
    /// The issuance currency for gift cards fulfilled from this product.
    /// > Note
    /// > This value can't be changed after the product is created.
    /// </summary>
    [JsonPropertyName("issuanceCurrency")]
    public CurrencyCode? issuanceCurrency { get; set; } = null;

    /// <summary>
    /// The metafields to associate with this product.
    /// Complexity cost: 0.4 per metafield.
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
    /// A list of variants associated with the gift card product.
    /// Complexity cost: 0.2 per variant.
    /// </summary>
    [JsonPropertyName("variants")]
    public ICollection<GiftCardProductVariantSetInput>? variants { get; set; } = null;

    /// <summary>
    /// The name of the product's vendor.
    /// </summary>
    [JsonPropertyName("vendor")]
    public string? vendor { get; set; } = null;
}