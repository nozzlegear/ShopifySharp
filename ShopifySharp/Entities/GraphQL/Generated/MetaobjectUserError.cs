#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Defines errors encountered while managing metaobject resources.
/// </summary>
public record MetaobjectUserError : IGraphQLObject, IDisplayableError
{
    /// <summary>
    /// The error code.
    /// </summary>
    [JsonPropertyName("code")]
    public MetaobjectUserErrorCode? code { get; set; } = null;

    /// <summary>
    /// The index of the failing list element in an array.
    /// </summary>
    [JsonPropertyName("elementIndex")]
    public int? elementIndex { get; set; } = null;

    /// <summary>
    /// The key of the failing object element.
    /// </summary>
    [JsonPropertyName("elementKey")]
    public string? elementKey { get; set; } = null;

    /// <summary>
    /// The path to the input field that caused the error.
    /// </summary>
    [JsonPropertyName("field")]
    public ICollection<string>? field { get; set; } = null;

    /// <summary>
    /// The error message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;
}