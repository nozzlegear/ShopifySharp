#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Defines errors encountered while managing a product bundle.
/// </summary>
public record ProductBundleMutationUserError : IGraphQLObject, IDisplayableError
{
    /// <summary>
    /// The error code.
    /// </summary>
    [JsonPropertyName("code")]
    public ProductBundleMutationUserErrorCode? code { get; set; } = null;

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