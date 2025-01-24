#nullable enable
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ShopifySharp.Converters.SystemTextJson;

namespace ShopifySharp.Services.Graph;

public record GraphErrorExtensions
{
    // TODO: make this nullable
    public string Code { get; set; } = string.Empty;

    public double? Cost { get; set; }

    public double? MaxCost { get; set; }

    public string? Documentation { get; set; }

    public string? TypeName { get; set; }

    public string? ArgumentName { get; set; }
}
