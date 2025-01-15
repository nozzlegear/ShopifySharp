#nullable enable
namespace ShopifySharp.Services.Graph;

public record GraphError
{
    #if NET8_0_OR_GREATER
    public required string Message { get; set; }
    #else
    public string Message { get; set; } = null!;
    #endif

    public GraphErrorExtensions? Extensions { get; set; }
}
