#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a delegate access token.
/// </summary>
public record DelegateAccessTokenInput : GraphQLInputObject<DelegateAccessTokenInput>
{
    /// <summary>
    /// The list of scopes that will be delegated to the new access token.
    /// </summary>
    [JsonPropertyName("delegateAccessScope")]
    public ICollection<string>? delegateAccessScope { get; set; } = null;

    /// <summary>
    /// The amount of time, in seconds, after which the delegate access token is no longer valid.
    /// </summary>
    [JsonPropertyName("expiresIn")]
    public int? expiresIn { get; set; } = null;
}