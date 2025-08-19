#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The attribute editable information.
/// </summary>
public record EditableProperty : IGraphQLObject
{
    /// <summary>
    /// Whether the attribute is locked for editing.
    /// </summary>
    [JsonPropertyName("locked")]
    public bool? locked { get; set; } = null;

    /// <summary>
    /// The reason the attribute is locked for editing.
    /// </summary>
    [JsonPropertyName("reason")]
    public string? reason { get; set; } = null;
}