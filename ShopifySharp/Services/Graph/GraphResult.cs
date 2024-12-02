#nullable enable

namespace ShopifySharp.Graph;

public class GraphResult<T>
{
    public GraphExtensions? Extensions { get; set; }

    public T Data { get; set; } = default!;

    public string? RequestId { get; set; }
}
