#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `shopPolicyUpdate` mutation.
/// </summary>
public record ShopPolicyUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The shop policy that has been updated.
    /// </summary>
    [JsonPropertyName("shopPolicy")]
    public ShopPolicy? shopPolicy { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ShopPolicyUserError>? userErrors { get; set; } = null;
}