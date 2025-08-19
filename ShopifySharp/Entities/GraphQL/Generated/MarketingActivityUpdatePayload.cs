#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `marketingActivityUpdate` mutation.
/// </summary>
public record MarketingActivityUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated marketing activity.
    /// </summary>
    [JsonPropertyName("marketingActivity")]
    public MarketingActivity? marketingActivity { get; set; } = null;

    /// <summary>
    /// The redirect path from the embedded editor to the Shopify admin.
    /// </summary>
    [JsonPropertyName("redirectPath")]
    public string? redirectPath { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}