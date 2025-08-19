#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a storefront access token.
/// </summary>
public record StorefrontAccessTokenInput : GraphQLInputObject<StorefrontAccessTokenInput>
{
    /// <summary>
    /// A title for the storefront access token.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}