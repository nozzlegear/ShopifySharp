#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A filter that takes a value that's associated with an object. For example, the
/// `tags` field is associated with the
/// [`Customer`](/api/admin-graphql/latest/objects/Customer) object.
/// </summary>
public record SegmentAssociationFilter : IGraphQLObject, ISegmentFilter
{
    /// <summary>
    /// The localized name of the filter.
    /// </summary>
    [JsonPropertyName("localizedName")]
    public string? localizedName { get; set; } = null;

    /// <summary>
    /// Whether a file can have multiple values for a single customer.
    /// </summary>
    [JsonPropertyName("multiValue")]
    public bool? multiValue { get; set; } = null;

    /// <summary>
    /// The query name of the filter.
    /// </summary>
    [JsonPropertyName("queryName")]
    public string? queryName { get; set; } = null;
}