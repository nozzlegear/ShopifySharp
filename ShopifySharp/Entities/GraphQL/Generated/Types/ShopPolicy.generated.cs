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
/// Policy that a merchant has configured for their store, such as their refund or privacy policy.
/// </summary>
public record ShopPolicy : IGraphQLObject, IHasPublishedTranslations, INode
{
    /// <summary>
    /// The text of the policy. The maximum size is 512kb.
    /// </summary>
    [JsonPropertyName("body")]
    public string? body { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) when the policy was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateOnly? createdAt { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The translated title of the policy. For example, Refund Policy or Politique de remboursement.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The published translations associated with the resource.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;

    /// <summary>
    /// The shop policy type.
    /// </summary>
    [JsonPropertyName("type")]
    public ShopPolicyType? type { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) when the policy was last modified.
    /// </summary>
    [JsonPropertyName("updatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateOnly? updatedAt { get; set; } = null;

    /// <summary>
    /// The public URL of the policy.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}