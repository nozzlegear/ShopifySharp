#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `savedSearchDelete` mutation.
/// </summary>
public record SavedSearchDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the saved search that was deleted.
    /// </summary>
    [JsonPropertyName("deletedSavedSearchId")]
    public string? deletedSavedSearchId { get; set; } = null;

    /// <summary>
    /// The shop of the saved search that was deleted.
    /// </summary>
    [JsonPropertyName("shop")]
    public Shop? shop { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}