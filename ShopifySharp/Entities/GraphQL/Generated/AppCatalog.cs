#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A catalog that defines the publication associated with an app.
/// </summary>
public record AppCatalog : IGraphQLObject, ICatalog, INode
{
    /// <summary>
    /// The apps associated with the catalog.
    /// </summary>
    [JsonPropertyName("apps")]
    public AppConnection? apps { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Most recent catalog operations.
    /// </summary>
    [JsonPropertyName("operations")]
    public ICollection<IResourceOperation>? operations { get; set; } = null;

    /// <summary>
    /// The price list associated with the catalog.
    /// </summary>
    [JsonPropertyName("priceList")]
    public PriceList? priceList { get; set; } = null;

    /// <summary>
    /// A group of products and collections that's published to a catalog.
    /// </summary>
    [JsonPropertyName("publication")]
    public Publication? publication { get; set; } = null;

    /// <summary>
    /// The status of the catalog.
    /// </summary>
    [JsonPropertyName("status")]
    public CatalogStatus? status { get; set; } = null;

    /// <summary>
    /// The name of the catalog.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}