#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `inventorySetScheduledChanges` mutation.
/// </summary>
public record InventorySetScheduledChangesPayload : IGraphQLObject
{
    /// <summary>
    /// The scheduled changes that were created.
    /// </summary>
    [JsonPropertyName("scheduledChanges")]
    public ICollection<InventoryScheduledChange>? scheduledChanges { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<InventorySetScheduledChangesUserError>? userErrors { get; set; } = null;
}