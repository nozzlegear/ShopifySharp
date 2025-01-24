#nullable enable
using System.Collections.Generic;

namespace ShopifySharp.Services.Graph;

public record GraphErrorExtensionsProblem
{
    public IReadOnlyList<string>? Path { get; set; }

    public string? Explanation { get; set; }

    public string? Message { get; set; }
}