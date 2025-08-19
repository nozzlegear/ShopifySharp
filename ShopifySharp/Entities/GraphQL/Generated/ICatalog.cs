#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A list of products with publishing and pricing information.
/// A catalog can be associated with a specific context, such as a
/// [`Market`](https://shopify.dev/api/admin-graphql/current/objects/market), [`CompanyLocation`](https://shopify.dev/api/admin-graphql/current/objects/companylocation),
/// or [`App`](https://shopify.dev/api/admin-graphql/current/objects/app).
/// </summary>
public interface ICatalog : IGraphQLObject
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }

    /// <summary>
    /// Most recent catalog operations.
    /// </summary>
    [JsonPropertyName("operations")]
    public ICollection<IResourceOperation>? operations { get; set; }

    /// <summary>
    /// The price list associated with the catalog.
    /// </summary>
    [JsonPropertyName("priceList")]
    public PriceList? priceList { get; set; }

    /// <summary>
    /// A group of products and collections that's published to a catalog.
    /// </summary>
    [JsonPropertyName("publication")]
    public Publication? publication { get; set; }

    /// <summary>
    /// The status of the catalog.
    /// </summary>
    [JsonPropertyName("status")]
    public CatalogStatus? status { get; set; }

    /// <summary>
    /// The name of the catalog.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; }
}