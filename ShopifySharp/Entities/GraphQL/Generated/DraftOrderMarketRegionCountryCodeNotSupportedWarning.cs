#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A warning indicating that the market region country code is not supported with Markets.
/// </summary>
public record DraftOrderMarketRegionCountryCodeNotSupportedWarning : IGraphQLObject, IDraftOrderWarning
{
    /// <summary>
    /// The error code.
    /// </summary>
    [JsonPropertyName("errorCode")]
    public string? errorCode { get; set; } = null;

    /// <summary>
    /// The input field that the warning applies to.
    /// </summary>
    [JsonPropertyName("field")]
    public string? field { get; set; } = null;

    /// <summary>
    /// The warning message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;
}