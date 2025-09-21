#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A resource that has translatable fields.
/// </summary>
public record TranslatableResource : IGraphQLObject
{
    /// <summary>
    /// Nested translatable resources under the current resource.
    /// </summary>
    [JsonPropertyName("nestedTranslatableResources")]
    public TranslatableResourceConnection? nestedTranslatableResources { get; set; } = null;

    /// <summary>
    /// GID of the resource.
    /// </summary>
    [JsonPropertyName("resourceId")]
    public string? resourceId { get; set; } = null;

    /// <summary>
    /// Translatable content.
    /// </summary>
    [JsonPropertyName("translatableContent")]
    public ICollection<TranslatableContent>? translatableContent { get; set; } = null;

    /// <summary>
    /// Translatable content translations (includes unpublished locales).
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;
}