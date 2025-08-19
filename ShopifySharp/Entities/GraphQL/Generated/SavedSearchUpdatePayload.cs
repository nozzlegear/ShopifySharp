#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `savedSearchUpdate` mutation.
/// </summary>
public record SavedSearchUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The saved search that was updated.
    /// </summary>
    [JsonPropertyName("savedSearch")]
    public SavedSearch? savedSearch { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}