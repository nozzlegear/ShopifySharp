#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A default cursor that you can use in queries to paginate your results. Each edge in a connection can
/// return a cursor, which is a reference to the edge's position in the connection. You can use an edge's cursor as
/// the starting point to retrieve the nodes before or after it in a connection.
/// To learn more about using cursor-based pagination, refer to
/// [Paginating results with GraphQL](https://shopify.dev/api/usage/pagination-graphql).
/// </summary>
public interface INavigable : IGraphQLObject
{
    /// <summary>
    /// A default [cursor](https://shopify.dev/api/usage/pagination-graphql) that
    /// returns the single next record, sorted ascending by ID.
    /// </summary>
    [JsonPropertyName("defaultCursor")]
    public string? defaultCursor { get; set; }
}