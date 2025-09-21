#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A token that delegates a set of scopes from the original permission.
/// To learn more about creating delegate access tokens, refer to
/// [Delegate OAuth access tokens to subsystems](https://shopify.dev/docs/apps/build/authentication-authorization/access-tokens/use-delegate-tokens).
/// </summary>
public record DelegateAccessToken : IGraphQLObject
{
    /// <summary>
    /// The list of permissions associated with the token.
    /// </summary>
    [JsonPropertyName("accessScopes")]
    public ICollection<string>? accessScopes { get; set; } = null;

    /// <summary>
    /// The issued delegate access token.
    /// </summary>
    [JsonPropertyName("accessToken")]
    public string? accessToken { get; set; } = null;

    /// <summary>
    /// The date and time when the delegate access token was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; } = null;
}