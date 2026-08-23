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
/// Represents a customer's identity provider subject identifier.
/// </summary>
public record IdentityProviderSubject : IGraphQLObject, INode
{
    /// <summary>
    /// The date and time when the provider subject was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// A globally-unique ID for the provider subject.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The merchant-configured name of the third-party identity provider.
    /// </summary>
    [JsonPropertyName("providerName")]
    public string? providerName { get; set; } = null;

    /// <summary>
    /// The unique subject identifier assigned to the customer by the authentication provider.
    /// </summary>
    [JsonPropertyName("subject")]
    public string? subject { get; set; } = null;

    /// <summary>
    /// The date and time when the provider subject was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;
}