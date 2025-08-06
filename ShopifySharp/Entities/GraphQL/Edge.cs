// ReSharper disable InconsistentNaming
#nullable enable
namespace ShopifySharp.GraphQL;

public interface IEdge<out TNode>
{
    string? cursor { get; }
    TNode? node { get; }
}

public abstract record Edge<TNode>: IEdge<TNode>
{
    public string? cursor { get; set; }
    public TNode? node { get; set; }
}
