#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A list of products with publishing and pricing information associated with company locations.
/// </summary>
public record CompanyLocationCatalog : IGraphQLObject, ICatalog, INode
{
    /// <summary>
    /// The company locations associated with the catalog.
    /// </summary>
    [JsonPropertyName("companyLocations")]
    public CompanyLocationConnection? companyLocations { get; set; } = null;

    /// <summary>
    /// The number of company locations associated with the catalog.
    /// </summary>
    [JsonPropertyName("companyLocationsCount")]
    public Count? companyLocationsCount { get; set; } = null;

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