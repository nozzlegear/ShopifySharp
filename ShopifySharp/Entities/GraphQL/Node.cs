#nullable enable
using System.Text.Json.Serialization;

namespace ShopifySharp.GraphQL;

public interface INode
{
    string Id { get; }
}

public sealed record Node : INode
{
    [JsonPropertyName("id")]
    public string Id { get; }
}
