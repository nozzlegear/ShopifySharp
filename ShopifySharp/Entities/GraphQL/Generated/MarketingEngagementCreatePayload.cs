#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `marketingEngagementCreate` mutation.
/// </summary>
public record MarketingEngagementCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The marketing engagement that was created. This represents customer activity
    /// taken on a marketing activity or a marketing channel.
    /// </summary>
    [JsonPropertyName("marketingEngagement")]
    public MarketingEngagement? marketingEngagement { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MarketingActivityUserError>? userErrors { get; set; } = null;
}