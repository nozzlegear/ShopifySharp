#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `storefrontAccessTokenCreate` mutation.
/// </summary>
public record StorefrontAccessTokenCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The user's shop.
    /// </summary>
    [JsonPropertyName("shop")]
    public Shop? shop { get; set; } = null;

    /// <summary>
    /// The storefront access token.
    /// </summary>
    [JsonPropertyName("storefrontAccessToken")]
    public StorefrontAccessToken? storefrontAccessToken { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}