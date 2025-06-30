#nullable enable
namespace ShopifySharp.GraphQL;

using System.Text.Json.Serialization;

/// <summary>
/// Returns information about pagination in a connection, in accordance with the
/// [Relay specification](https://relay.dev/graphql/connections.htm#sec-undefined.PageInfo).
/// For more information, please read our [GraphQL Pagination Usage Guide](https://shopify.dev/api/usage/pagination-graphql).
/// </summary>
public record PageInfo : GraphQLObject<PageInfo>
{
    /// <summary>
    /// The cursor corresponding to the last node in edges.
    /// </summary>
    [JsonPropertyName("endCursor")]
    public string? endCursor { get; set; }

    /// <summary>
    /// Whether there are more pages to fetch following the current page.
    /// </summary>
    [JsonPropertyName("hasNextPage")]
    public bool? hasNextPage { get; set; }

    /// <summary>
    /// Whether there are any pages prior to the current page.
    /// </summary>
    [JsonPropertyName("hasPreviousPage")]
    public bool? hasPreviousPage { get; set; }

    /// <summary>
    /// The cursor corresponding to the first node in edges.
    /// </summary>
    [JsonPropertyName("startCursor")]
    public string? startCursor { get; set; }
}
