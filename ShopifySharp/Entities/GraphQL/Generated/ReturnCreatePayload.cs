#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `returnCreate` mutation.
/// </summary>
public record ReturnCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The created return.
    /// </summary>
    [JsonPropertyName("return")]
    public Return? @return { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ReturnUserError>? userErrors { get; set; } = null;
}