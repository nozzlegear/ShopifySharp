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
/// Return type for `delegateAccessTokenDestroy` mutation.
/// </summary>
public record DelegateAccessTokenDestroyPayload : IGraphQLObject
{
    /// <summary>
    /// The user's shop.
    /// </summary>
    [JsonPropertyName("shop")]
    public Shop? shop { get; set; } = null;

    /// <summary>
    /// The status of the delegate access token destroy operation. Returns true if successful.
    /// </summary>
    [JsonPropertyName("status")]
    public bool? status { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DelegateAccessTokenDestroyUserError>? userErrors { get; set; } = null;
}