#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A file error. This typically occurs when there is an issue with the file itself causing it to fail validation.
/// Check the file before attempting to upload again.
/// </summary>
public record FileError : IGraphQLObject
{
    /// <summary>
    /// Code representing the type of error.
    /// </summary>
    [JsonPropertyName("code")]
    public FileErrorCode? code { get; set; } = null;

    /// <summary>
    /// Additional details regarding the error.
    /// </summary>
    [JsonPropertyName("details")]
    public string? details { get; set; } = null;

    /// <summary>
    /// Translated error message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;
}