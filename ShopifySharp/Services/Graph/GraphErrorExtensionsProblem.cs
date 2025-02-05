#nullable enable
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ShopifySharp.Converters.SystemTextJson;

namespace ShopifySharp.Services.Graph;

public record GraphErrorExtensionsProblem
{
    [JsonConverter(typeof(PrimitiveStringConverterFactory))]
    public IReadOnlyList<string>? Path { get; set; }

    public string? Explanation { get; set; }

    public string? Message { get; set; }
}
