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
/// Defines a relation between two resources via a reference metafield.
/// The referencer owns the joining field with a given namespace and key,
/// while the target is referenced by the field.
/// </summary>
public record MetafieldRelation : IGraphQLObject
{
    /// <summary>
    /// The key of the field making the reference.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The name of the field making the reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The namespace of the metafield making the reference, or type of the metaobject.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? @namespace { get; set; } = null;

    /// <summary>
    /// The resource making the reference.
    /// </summary>
    [JsonPropertyName("referencer")]
    public MetafieldReferencer? referencer { get; set; } = null;

    /// <summary>
    /// The referenced resource.
    /// </summary>
    [JsonPropertyName("target")]
    [Obsolete("No longer supported. Access the object directly instead.")]
    public MetafieldReference? target { get; set; } = null;
}