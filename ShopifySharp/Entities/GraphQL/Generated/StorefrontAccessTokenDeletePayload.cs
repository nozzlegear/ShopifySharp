#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `storefrontAccessTokenDelete` mutation.
/// </summary>
public record StorefrontAccessTokenDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted storefront access token.
    /// </summary>
    [JsonPropertyName("deletedStorefrontAccessTokenId")]
    public string? deletedStorefrontAccessTokenId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}