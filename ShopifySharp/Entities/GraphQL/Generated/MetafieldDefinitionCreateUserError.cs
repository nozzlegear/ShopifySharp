#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// An error that occurs during the execution of `MetafieldDefinitionCreate`.
/// </summary>
public record MetafieldDefinitionCreateUserError : IGraphQLObject, IDisplayableError
{
    /// <summary>
    /// The error code.
    /// </summary>
    [JsonPropertyName("code")]
    public MetafieldDefinitionCreateUserErrorCode? code { get; set; } = null;

    /// <summary>
    /// The index of the array element that's causing the error.
    /// </summary>
    [JsonPropertyName("elementIndex")]
    public int? elementIndex { get; set; } = null;

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