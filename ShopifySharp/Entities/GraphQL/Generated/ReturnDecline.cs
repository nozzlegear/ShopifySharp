#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Additional information about why a merchant declined the customer's return request.
/// </summary>
public record ReturnDecline : IGraphQLObject
{
    /// <summary>
    /// The notification message sent to the customer about their declined return request.
    /// Maximum length: 500 characters.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The reason the customer's return request was declined.
    /// </summary>
    [JsonPropertyName("reason")]
    public ReturnDeclineReason? reason { get; set; } = null;
}