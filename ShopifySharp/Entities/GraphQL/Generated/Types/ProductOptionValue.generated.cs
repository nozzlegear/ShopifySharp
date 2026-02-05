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
/// A specific value for a [`ProductOption`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductOption),
/// such as "Red" or "Blue" for a "Color" option. Each value can be assigned to [`ProductVariant`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant)
/// objects to create different versions of a
/// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product).
/// The value tracks whether any variants currently use it through the [`hasVariants`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductOptionValue#field-hasVariants)
/// field. Values can include visual representations through swatches that display
/// colors or images. When linked to a [`Metafield`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Metafield), the [`linkedMetafieldValue`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductOptionValue#field-linkedMetafieldValue)
/// provides additional structured data for the option value.
/// </summary>
public record ProductOptionValue : IGraphQLObject, IHasPublishedTranslations, INode
{
    /// <summary>
    /// Whether the product option value has any linked variants.
    /// </summary>
    [JsonPropertyName("hasVariants")]
    public bool? hasVariants { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The value of the linked metafield.
    /// </summary>
    [JsonPropertyName("linkedMetafieldValue")]
    public string? linkedMetafieldValue { get; set; } = null;

    /// <summary>
    /// The name of the product option value.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The swatch associated with the product option value.
    /// </summary>
    [JsonPropertyName("swatch")]
    public ProductOptionValueSwatch? swatch { get; set; } = null;

    /// <summary>
    /// The published translations associated with the resource.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;
}