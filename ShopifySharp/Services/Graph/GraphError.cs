#nullable enable
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ShopifySharp.Converters.SystemTextJson;

namespace ShopifySharp.Services.Graph;

public record GraphError
{
    // TODO: make this nullable
    public string Message { get; set; } = string.Empty;

    [JsonConverter(typeof(PrimitiveStringConverterFactory))]
    public IReadOnlyList<string>? Path { get; set; }

    public GraphErrorExtensions? Extensions { get; set; }
}
