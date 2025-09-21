#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a media warning. This occurs when there is a non-blocking concern regarding your media.
/// Consider reviewing your media to ensure it is correct and its parameters are as expected.
/// </summary>
public record MediaWarning : IGraphQLObject
{
    /// <summary>
    /// The code representing the type of warning.
    /// </summary>
    [JsonPropertyName("code")]
    public MediaWarningCode? code { get; set; } = null;

    /// <summary>
    /// Translated warning message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;
}