// ReSharper disable InconsistentNaming
#nullable enable
namespace ShopifySharp.GraphQL;

using System.Text.Json.Serialization;

/// <summary>
/// Returns information about pagination in a connection, in accordance with the
/// [Relay specification](https://relay.dev/graphql/connections.htm#sec-undefined.PageInfo).
/// For more information, please read our [GraphQL Pagination Usage Guide](https://shopify.dev/api/usage/pagination-graphql).
/// </summary>
public sealed record PageInfo(
    string? startCursor,
    string? endCursor,
    bool    hasPreviousPage,
    bool    hasNextPage)
{
    /// <summary>
    /// The cursor corresponding to the first node in edges.
    /// </summary>
    [JsonPropertyName("startCursor")]
    public string? startCursor { get; set; } = startCursor;

    /// <summary>
    /// The cursor corresponding to the last node in edges.
    /// </summary>
    [JsonPropertyName("endCursor")]
    public string? endCursor { get; set; } = endCursor;

    /// <summary>
    /// Whether there are more pages to fetch following the current page.
    /// </summary>
    [JsonPropertyName("hasNextPage")]
    public bool hasNextPage { get; set; } = hasNextPage;

    /// <summary>
    /// Whether there are any pages prior to the current page.
    /// </summary>
    [JsonPropertyName("hasPreviousPage")]
    public bool hasPreviousPage { get; set; } = hasPreviousPage;
}
