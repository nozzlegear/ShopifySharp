#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `cartTransformCreate` mutation.
/// </summary>
public record CartTransformCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The newly created cart transform function.
    /// </summary>
    [JsonPropertyName("cartTransform")]
    public CartTransform? cartTransform { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CartTransformCreateUserError>? userErrors { get; set; } = null;
}