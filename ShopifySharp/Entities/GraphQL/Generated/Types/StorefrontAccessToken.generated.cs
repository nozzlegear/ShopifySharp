#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A token that delegates unauthenticated access scopes to clients that need to
/// access the [Storefront API](https://shopify.dev/docs/api/storefront). Storefront
/// access tokens enable headless storefronts and custom applications to interact
/// with a store on behalf of customers without requiring authentication.
/// The token provides specific permissions, such as reading
/// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
/// data, managing carts, or creating
/// [`Customer`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Customer)
/// accounts. An app can have a maximum of 100 active storefront access tokens for
/// each [`Shop`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Shop).
/// Learn more about [building with the Storefront API](https://shopify.dev/docs/storefronts/headless/building-with-the-storefront-api/getting-started).
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
    public DateTimeOffset? createdAt { get; set; } = null;

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
    public DateTimeOffset? updatedAt { get; set; } = null;
}