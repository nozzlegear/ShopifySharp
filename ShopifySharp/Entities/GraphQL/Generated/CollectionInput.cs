#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to create a collection.
/// </summary>
public record CollectionInput : GraphQLInputObject<CollectionInput>
{
    /// <summary>
    /// The description of the collection, in HTML format.
    /// </summary>
    [JsonPropertyName("descriptionHtml")]
    public string? descriptionHtml { get; set; } = null;

    /// <summary>
    /// A unique human-friendly string for the collection. Automatically generated from the collection's title.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// Specifies the collection to update or create a new collection if absent. Required for updating a collection.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The image associated with the collection.
    /// </summary>
    [JsonPropertyName("image")]
    public ImageInput? image { get; set; } = null;

    /// <summary>
    /// The metafields to associate with the collection.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// Initial list of collection products. Only valid with `collectionCreate` and without rules.
    /// </summary>
    [JsonPropertyName("products")]
    public ICollection<string>? products { get; set; } = null;

    /// <summary>
    /// Indicates whether a redirect is required after a new handle has been provided.
    /// If true, then the old handle is redirected to the new one automatically.
    /// </summary>
    [JsonPropertyName("redirectNewHandle")]
    public bool? redirectNewHandle { get; set; } = null;

    /// <summary>
    /// The rules used to assign products to the collection.
    /// </summary>
    [JsonPropertyName("ruleSet")]
    public CollectionRuleSetInput? ruleSet { get; set; } = null;

    /// <summary>
    /// SEO information for the collection.
    /// </summary>
    [JsonPropertyName("seo")]
    public SEOInput? seo { get; set; } = null;

    /// <summary>
    /// The order in which the collection's products are sorted.
    /// </summary>
    [JsonPropertyName("sortOrder")]
    public CollectionSortOrder? sortOrder { get; set; } = null;

    /// <summary>
    /// The theme template used when viewing the collection in a store.
    /// </summary>
    [JsonPropertyName("templateSuffix")]
    public string? templateSuffix { get; set; } = null;

    /// <summary>
    /// The title of the collection. Required for creating a new collection.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}