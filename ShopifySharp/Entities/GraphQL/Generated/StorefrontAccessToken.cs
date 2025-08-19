#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A token that's used to delegate unauthenticated access scopes to clients that need to access
/// the unauthenticated [Storefront API](https://shopify.dev/docs/api/storefront).
/// An app can have a maximum of 100 active storefront access
/// tokens for each shop.
/// [Get started with the Storefront API](https://shopify.dev/docs/storefronts/headless/building-with-the-storefront-api/getting-started).
/// </summary>
public record StorefrontAccessToken : IGraphQLObject, INode
{
    /// <summary>
    /// List of permissions associated with the token.
    /// </summary>
    [JsonPropertyName("accessScopes")]
    public ICollection<AccessScope>? accessScopes { get; set; } = null;

    /// <summary>
    /// The issued public access token.
    /// </summary>
    [JsonPropertyName("accessToken")]
    public string? accessToken { get; set; } = null;

    /// <summary>
    /// The date and time when the public access token was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// An arbitrary title for each token determined by the developer, used for reference         purposes.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The date and time when the storefront access token was updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? updatedAt { get; set; } = null;
}