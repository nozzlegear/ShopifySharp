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
/// Return type for `appRevokeAccessScopes` mutation.
/// </summary>
public record AppRevokeAccessScopesPayload : IGraphQLObject
{
    /// <summary>
    /// The list of scope handles that have been revoked.
    /// </summary>
    [JsonPropertyName("revoked")]
    public ICollection<AccessScope>? revoked { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<AppRevokeAccessScopesAppRevokeScopeError>? userErrors { get; set; } = null;
}