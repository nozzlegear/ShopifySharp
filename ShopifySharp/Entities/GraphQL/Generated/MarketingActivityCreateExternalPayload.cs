#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `marketingActivityCreateExternal` mutation.
/// </summary>
public record MarketingActivityCreateExternalPayload : IGraphQLObject
{
    /// <summary>
    /// The external marketing activity that was created.
    /// </summary>
    [JsonPropertyName("marketingActivity")]
    public MarketingActivity? marketingActivity { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MarketingActivityUserError>? userErrors { get; set; } = null;
}