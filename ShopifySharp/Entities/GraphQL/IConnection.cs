// ReSharper disable InconsistentNaming
// ReSharper disable UnusedAutoPropertyAccessor.Global
#nullable enable

namespace ShopifySharp.GraphQL;

using System;
using System.Collections.Generic;

public interface IConnection : IGraphQLObject
{
    PageInfo? pageInfo { get; }
    int? totalCount { get; }
    Type GetNodeType();
}

public interface IHasEdges<out TEdge>
{
    IReadOnlyList<TEdge> edges { get; }
}

public interface IHasNodes<out TNode>
{
    IReadOnlyList<TNode> nodes { get; }
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
    public IReadOnlyList<Edge<TNode>> edges { get; set; } = [];
    public PageInfo? pageInfo { get; set; }
    public int? totalCount { get; set; } = null;

    public Type GetNodeType() => typeof(TNode);
}

public abstract record ConnectionWithNodes<TNode> : IConnectionWithNodes<TNode>
{
    public IReadOnlyList<TNode> nodes { get; set; } = [];
    public PageInfo? pageInfo { get; set; }
    public int? totalCount { get; set; } = null;

    public Type GetNodeType() => typeof(TNode);
}

public abstract record ConnectionWithNodesAndEdges<TNode> : IConnectionWithNodesAndEdges<TNode>
{
    public IReadOnlyList<Edge<TNode>> edges { get; set; } = [];
    public IReadOnlyList<TNode> nodes { get; set; } = [];
    public PageInfo? pageInfo { get; set; }
    public int? totalCount { get; set; } = null;

    public Type GetNodeType() => typeof(TNode);
}
