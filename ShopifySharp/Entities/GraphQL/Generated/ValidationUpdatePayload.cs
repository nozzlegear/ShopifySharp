#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `validationUpdate` mutation.
/// </summary>
public record ValidationUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ValidationUserError>? userErrors { get; set; } = null;

    /// <summary>
    /// The updated validation.
    /// </summary>
    [JsonPropertyName("validation")]
    public Validation? validation { get; set; } = null;
}