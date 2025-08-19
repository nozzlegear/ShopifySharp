#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `publicationCreate` mutation.
/// </summary>
public record PublicationCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The publication that's been created.
    /// </summary>
    [JsonPropertyName("publication")]
    public Publication? publication { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PublicationUserError>? userErrors { get; set; } = null;
}