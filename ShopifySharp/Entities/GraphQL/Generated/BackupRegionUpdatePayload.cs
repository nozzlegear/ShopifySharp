#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `backupRegionUpdate` mutation.
/// </summary>
public record BackupRegionUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// Returns the updated backup region.
    /// </summary>
    [JsonPropertyName("backupRegion")]
    public IMarketRegion? backupRegion { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MarketUserError>? userErrors { get; set; } = null;
}