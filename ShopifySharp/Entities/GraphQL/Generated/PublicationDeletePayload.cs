#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `publicationDelete` mutation.
/// </summary>
public record PublicationDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the publication that was deleted.
    /// </summary>
    [JsonPropertyName("deletedId")]
    public string? deletedId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PublicationUserError>? userErrors { get; set; } = null;
}