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
/// The input fields for specifying a gift card product variant to create or update with the
/// [`giftCardProductSet`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/giftCardProductSet)
/// mutation.
/// Include an
/// [`id`](https://shopify.dev/docs/api/admin-graphql/latest/input-objects/GiftCardProductSetVariantInput#field-GiftCardProductSetVariantInput.fields.id)
/// to update an existing variant, or omit it to create a new one. Gift card variant defaults are
/// applied automatically, meaning variants are set to non-taxable, don't require shipping, and their inventory is untracked.
/// </summary>
public record GiftCardProductVariantSetInput : GraphQLInputObject<GiftCardProductVariantSetInput>
{
    /// <summary>
    /// The value of the barcode associated with the product.
    /// </summary>
    [JsonPropertyName("barcode")]
    public string? barcode { get; set; } = null;

    /// <summary>
    /// The file to associate with the variant.
    /// Complexity cost: 0.6 per variant file.
    /// Any file specified here must also be specified in the `files` input for the product.
    /// </summary>
    [JsonPropertyName("file")]
    public FileSetInput? file { get; set; } = null;

    /// <summary>
    /// Specifies the product variant to update or create a new variant if absent.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Additional customizable information about the product variant.
    /// Complexity cost: 0.4 per variant metafield.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// The custom properties that a shop owner uses to define product variants.
    /// </summary>
    [JsonPropertyName("optionValues")]
    public ICollection<VariantOptionValueInput>? optionValues { get; set; } = null;

    /// <summary>
    /// The order of the product variant in the list of product variants. The first position in the list is 1.
    /// </summary>
    [JsonPropertyName("position")]
    public int? position { get; set; } = null;

    /// <summary>
    /// The price of the variant.
    /// </summary>
    [JsonPropertyName("price")]
    public decimal? price { get; set; } = null;

    /// <summary>
    /// Indicates whether the product variant is created as published or unpublished.
    /// This option is only available for new product variants.
    /// </summary>
    [JsonPropertyName("published")]
    public bool? published { get; set; } = null;

    /// <summary>
    /// The SKU for the variant. Case-sensitive string.
    /// </summary>
    [JsonPropertyName("sku")]
    public string? sku { get; set; } = null;
}