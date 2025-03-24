#nullable enable
namespace ShopifySharp.Identifiers;

public interface IShopifyGraphId
{
    public string GraphId { get; }
    public string ResourceType { get; }
    public long RestId { get; }

    #if NETSTANDARD2_0
    string ToString();
    #else
    public string ToString() => GraphId;
    #endif
}
