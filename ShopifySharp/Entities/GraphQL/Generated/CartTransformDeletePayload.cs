#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `cartTransformDelete` mutation.
/// </summary>
public record CartTransformDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The globally-unique ID for the deleted cart transform.
    /// </summary>
    [JsonPropertyName("deletedId")]
    public string? deletedId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CartTransformDeleteUserError>? userErrors { get; set; } = null;
}