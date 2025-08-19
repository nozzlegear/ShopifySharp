#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `validationCreate` mutation.
/// </summary>
public record ValidationCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ValidationUserError>? userErrors { get; set; } = null;

    /// <summary>
    /// The created validation.
    /// </summary>
    [JsonPropertyName("validation")]
    public Validation? validation { get; set; } = null;
}