#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to delete a storefront access token.
/// </summary>
public record StorefrontAccessTokenDeleteInput : GraphQLInputObject<StorefrontAccessTokenDeleteInput>
{
    /// <summary>
    /// The ID of the storefront access token to delete.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}