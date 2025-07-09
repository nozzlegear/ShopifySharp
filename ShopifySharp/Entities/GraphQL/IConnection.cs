#nullable enable

namespace ShopifySharp.GraphQL;

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public interface INode
{
    string Id { get; }
}

public sealed record Node : INode
{
    [JsonPropertyName("id")]
    public string Id { get; }
}

public interface IEdge<out TNode>
{
    string? Cursor { get; }
    TNode? Node { get; }
}

public abstract record Edge<TNode>: IEdge<TNode>
{
    public string? Cursor { get; set; }
    public TNode? Node { get; set; }
}

/// <summary>
/// Returns information about pagination in a connection, in accordance with the
/// [Relay specification](https://relay.dev/graphql/connections.htm#sec-undefined.PageInfo).
/// For more information, please read our [GraphQL Pagination Usage Guide](https://shopify.dev/api/usage/pagination-graphql).
/// </summary>
public sealed record PageInfo(
    string? StartCursor,
    string? EndCursor,
    bool    HasPreviousPage,
    bool    HasNextPage)
{
    /// The cursor corresponding to the first node in edges.
    [JsonPropertyName("startCursor")]
    public string? StartCursor { get; set; } = StartCursor;

    /// The cursor corresponding to the last node in edges.
    [JsonPropertyName("endCursor")]
    public readonly string? EndCursor = EndCursor;

    /// Whether there are more pages to fetch following the current page.
    [JsonPropertyName("hasNextPage")]
    public readonly bool HasNextPage = HasNextPage;

    /// Whether there are any pages prior to the current page.
    [JsonPropertyName("hasPreviousPage")]
    public readonly bool HasPreviousPage = HasPreviousPage;
}

// ── shared pagination contract ────────────────────────────────────────────────
public interface IConnection
{
    PageInfo? PageInfo { get; }
    int? TotalCount { get; }
    Type GetNodeType();
}

// ── capability markers ───────────────────────────────────────────────────────
public interface IHasEdges<out TEdge>
{
    IReadOnlyList<TEdge> Edges { get; }
}

public interface IHasNodes<out TNode>
{
    IReadOnlyList<TNode> Nodes { get; }
}

// ── variants ─────────────────────────────────────────────────────────────────
public interface IConnectionWithEdges<TNode> :
    IConnection,
    IHasEdges<Edge<TNode>> { }

public interface IConnectionWithNodes<out TNode> :
    IConnection,
    IHasNodes<TNode> { }

public interface IConnectionWithNodesAndEdges<TNode> :
    IConnection,
    IHasEdges<Edge<TNode>>,
    IHasNodes<TNode> { }

public abstract record ConnectionWithEdges<TNode> : IConnectionWithEdges<TNode>
{
    public IReadOnlyList<Edge<TNode>> Edges { get; set; } = [];
    public PageInfo? PageInfo { get; set; }
    public int? TotalCount { get; set; } = null;

    public Type GetNodeType() => typeof(TNode);
}

public abstract record ConnectionWithNodes<TNode> : IConnectionWithNodes<TNode>
{
    public IReadOnlyList<TNode> Nodes { get; set; } = [];
    public PageInfo? PageInfo { get; set; }
    public int? TotalCount { get; set; } = null;

    public Type GetNodeType() => typeof(TNode);
}

public abstract record ConnectionWithNodesAndEdges<TNode> : IConnectionWithNodesAndEdges<TNode>
{
    public IReadOnlyList<Edge<TNode>> Edges { get; set; } = [];
    public IReadOnlyList<TNode> Nodes { get; set; } = [];
    public PageInfo? PageInfo { get; set; }
    public int? TotalCount { get; set; } = null;

    public Type GetNodeType() => typeof(TNode);
}
