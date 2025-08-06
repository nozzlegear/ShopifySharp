#nullable enable
namespace ShopifySharp.GraphQL;

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
