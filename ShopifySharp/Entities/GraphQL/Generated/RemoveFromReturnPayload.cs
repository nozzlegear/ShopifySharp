#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `removeFromReturn` mutation.
/// </summary>
public record RemoveFromReturnPayload : IGraphQLObject
{
    /// <summary>
    /// The modified return.
    /// </summary>
    [JsonPropertyName("return")]
    public Return? @return { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ReturnUserError>? userErrors { get; set; } = null;
}