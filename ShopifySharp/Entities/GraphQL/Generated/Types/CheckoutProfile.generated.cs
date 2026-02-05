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
/// A checkout profile defines the branding settings and the UI extensions for a
/// store's checkout. A checkout profile could be published or draft. A store might
/// have at most one published checkout profile, which is used to render their live
/// checkout. The store could also have multiple draft profiles that were created,
/// previewed, and published using the admin checkout editor.
/// </summary>
public record CheckoutProfile : IGraphQLObject, INode
{
    /// <summary>
    /// The date and time when the checkout profile was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// The date and time when the checkout profile was last edited.
    /// </summary>
    [JsonPropertyName("editedAt")]
    public DateTimeOffset? editedAt { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether the checkout profile is published or not.
    /// </summary>
    [JsonPropertyName("isPublished")]
    public bool? isPublished { get; set; } = null;

    /// <summary>
    /// The profile name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Whether the checkout profile Thank You Page and Order Status Page are actively using extensibility or not.
    /// </summary>
    [JsonPropertyName("typOspPagesActive")]
    public bool? typOspPagesActive { get; set; } = null;

    /// <summary>
    /// The date and time when the checkout profile was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;
}