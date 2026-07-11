#nullable enable
using System.Text.Json.Serialization;

namespace ShopifySharp.GraphQL;

public sealed record Node : INode
{
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}
