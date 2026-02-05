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
/// A product attribute that customers can choose from, such as "Size", "Color", or "Material".
/// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
/// objects use options to define the different variations available for purchase.
/// Each option has a name and a set of possible values that combine to create [`ProductVariant`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant) objects.
/// The option includes its display position, associated values, and optional [`LinkedMetafield`](https://shopify.dev/docs/api/admin-graphql/latest/objects/LinkedMetafield)
/// for structured data. Options support translations for international selling and track which [`ProductOptionValue`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductOptionValue)
/// objects that variants actively use versus unused values that exist without
/// associated variants.
/// </summary>
public record ProductOption : IGraphQLObject, IHasPublishedTranslations, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The metafield identifier linked to this option.
    /// </summary>
    [JsonPropertyName("linkedMetafield")]
    public LinkedMetafield? linkedMetafield { get; set; } = null;

    /// <summary>
    /// The product option’s name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Similar to values, option_values returns all the corresponding option value
    /// objects to the product option, including values not assigned to any variants.
    /// </summary>
    [JsonPropertyName("optionValues")]
    public ICollection<ProductOptionValue>? optionValues { get; set; } = null;

    /// <summary>
    /// The product option's position.
    /// </summary>
    [JsonPropertyName("position")]
    public int? position { get; set; } = null;

    /// <summary>
    /// The published translations associated with the resource.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;

    /// <summary>
    /// The corresponding value to the product option name.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<string>? values { get; set; } = null;
}