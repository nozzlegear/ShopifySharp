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
/// A catalog for managing product availability and pricing for specific
/// [`Market`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Market)
/// contexts. Each catalog links to one or more markets and defines what
/// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
/// objects customers see through its [`Publication`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication)
/// settings. The catalog can include a [`PriceList`](https://shopify.dev/docs/api/admin-graphql/latest/objects/PriceList)
/// for market-specific pricing adjustments.
/// Use catalogs to create distinct shopping experiences for different geographic regions or customer segments.
/// Learn more about [building a
/// catalog](https://shopify.dev/docs/apps/build/markets/build-catalog) and
/// [managing markets](https://shopify.dev/docs/apps/build/markets).
/// </summary>
public record MarketCatalog : IGraphQLObject, ICatalog, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The markets associated with the catalog.
    /// </summary>
    [JsonPropertyName("markets")]
    public MarketConnection? markets { get; set; } = null;

    /// <summary>
    /// The number of markets associated with the catalog.
    /// </summary>
    [JsonPropertyName("marketsCount")]
    public Count? marketsCount { get; set; } = null;

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