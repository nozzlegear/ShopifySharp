#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `delegateAccessTokenCreate` mutation.
/// </summary>
public record DelegateAccessTokenCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The delegate access token.
    /// </summary>
    [JsonPropertyName("delegateAccessToken")]
    public DelegateAccessToken? delegateAccessToken { get; set; } = null;

    /// <summary>
    /// The user's shop.
    /// </summary>
    [JsonPropertyName("shop")]
    public Shop? shop { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DelegateAccessTokenCreateUserError>? userErrors { get; set; } = null;
}