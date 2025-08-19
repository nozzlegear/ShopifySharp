#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `validationDelete` mutation.
/// </summary>
public record ValidationDeletePayload : IGraphQLObject
{
    /// <summary>
    /// Returns the deleted validation ID.
    /// </summary>
    [JsonPropertyName("deletedId")]
    public string? deletedId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ValidationUserError>? userErrors { get; set; } = null;
}