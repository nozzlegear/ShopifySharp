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