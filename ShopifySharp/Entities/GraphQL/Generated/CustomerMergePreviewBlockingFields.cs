#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The blocking fields of a customer merge preview. These fields will block customer merge unless edited.
/// </summary>
public record CustomerMergePreviewBlockingFields : IGraphQLObject
{
    /// <summary>
    /// The merged note resulting from a customer merge. The merged note is over the
    /// 5000 character limit and will block customer merge.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The merged tags resulting from a customer merge. The merged tags are over the 250 limit and will block customer merge.
    /// </summary>
    [JsonPropertyName("tags")]
    public ICollection<string>? tags { get; set; } = null;
}