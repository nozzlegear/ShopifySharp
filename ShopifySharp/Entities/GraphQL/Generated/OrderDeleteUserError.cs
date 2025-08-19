#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Errors related to deleting an order.
/// </summary>
public record OrderDeleteUserError : IGraphQLObject, IDisplayableError
{
    /// <summary>
    /// The error code.
    /// </summary>
    [JsonPropertyName("code")]
    public OrderDeleteUserErrorCode? code { get; set; } = null;

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