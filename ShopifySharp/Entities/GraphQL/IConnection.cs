#nullable enable

namespace ShopifySharp.GraphQL;

using System;
using System.Collections.Generic;

public interface IConnection
{
    PageInfo? PageInfo { get; }
    int? TotalCount { get; }
    Type GetNodeType();
}

public interface IHasEdges<out TEdge>
{
    IReadOnlyList<TEdge> Edges { get; }
}

public interface IHasNodes<out TNode>
{
    IReadOnlyList<TNode> Nodes { get; }
}

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
