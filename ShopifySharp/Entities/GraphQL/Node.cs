#nullable enable
using System.Text.Json.Serialization;

namespace ShopifySharp.GraphQL;

public interface INode : IGraphQLObject
{
    // ReSharper disable once InconsistentNaming
    string? id { get; }
}

public sealed record Node : INode
{
    [JsonPropertyName("id")]
    public string? id { get; } = null;
}
