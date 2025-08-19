#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `marketingActivityDeleteExternal` mutation.
/// </summary>
public record MarketingActivityDeleteExternalPayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the marketing activity that was deleted, if one was deleted.
    /// </summary>
    [JsonPropertyName("deletedMarketingActivityId")]
    public string? deletedMarketingActivityId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MarketingActivityUserError>? userErrors { get; set; } = null;
}