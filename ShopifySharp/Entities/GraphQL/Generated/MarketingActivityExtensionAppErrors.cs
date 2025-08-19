#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents errors returned from apps when using the marketing activity extension.
/// </summary>
public record MarketingActivityExtensionAppErrors : IGraphQLObject
{
    /// <summary>
    /// The app error type.
    /// </summary>
    [JsonPropertyName("code")]
    public MarketingActivityExtensionAppErrorCode? code { get; set; } = null;

    /// <summary>
    /// The list of errors returned by the app.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}