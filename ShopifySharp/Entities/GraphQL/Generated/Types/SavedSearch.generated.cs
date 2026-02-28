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
/// A representation of a search query in the Shopify admin used on resource index
/// views. Preserves complex queries with search terms and filters, enabling
/// merchants to quickly access frequently used data views. For example, a saved
/// search can be applied to the product index table to filter products. The query
/// string combines free-text search terms with structured filters to narrow results
/// based on resource attributes.
/// The search applies to a specific resource type such as [`Customer`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Customer),
/// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product),
/// [`Order`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order), or [`Collection`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Collection) objects.
/// </summary>
public record SavedSearch : IGraphQLObject, ILegacyInteroperability, INode
{
    /// <summary>
    /// The filters of a saved search.
    /// </summary>
    [JsonPropertyName("filters")]
    public ICollection<SearchFilter>? filters { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; } = null;

    /// <summary>
    /// The name of a saved search.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The query string of a saved search. This includes search terms and filters.
    /// </summary>
    [JsonPropertyName("query")]
    public string? query { get; set; } = null;

    /// <summary>
    /// The type of resource this saved search is searching in.
    /// </summary>
    [JsonPropertyName("resourceType")]
    public SearchResultType? resourceType { get; set; } = null;

    /// <summary>
    /// The search terms of a saved search.
    /// </summary>
    [JsonPropertyName("searchTerms")]
    public string? searchTerms { get; set; } = null;
}