#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `appUsageRecordCreate` mutation.
/// </summary>
public record AppUsageRecordCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The newly created app usage record.
    /// </summary>
    [JsonPropertyName("appUsageRecord")]
    public AppUsageRecord? appUsageRecord { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}