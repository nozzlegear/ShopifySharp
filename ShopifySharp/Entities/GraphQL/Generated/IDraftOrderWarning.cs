#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A warning that is displayed to the merchant when a change is made to a draft order.
/// </summary>
public interface IDraftOrderWarning : IGraphQLObject
{
    /// <summary>
    /// The error code.
    /// </summary>
    [JsonPropertyName("errorCode")]
    public string? errorCode { get; set; }

    /// <summary>
    /// The input field that the warning applies to.
    /// </summary>
    [JsonPropertyName("field")]
    public string? field { get; set; }

    /// <summary>
    /// The warning message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; }
}