namespace ShopifySharp.Services.Graph;

public record GraphErrorExtensions
{
#if NET8_0_OR_GREATER
    public required string Code { get; set; }
#else
    public string Code { get; set; } = null!;
#endif

    public double? Cost { get; set; }

    public double? MaxCost { get; set; }

    public string? Documentation { get; set; }
}