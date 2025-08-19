#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Information about the admin filterable capability on a metafield definition.
/// </summary>
public record MetafieldCapabilityAdminFilterable : IGraphQLObject
{
    /// <summary>
    /// Indicates if the definition is eligible to have the capability.
    /// </summary>
    [JsonPropertyName("eligible")]
    public bool? eligible { get; set; } = null;

    /// <summary>
    /// Indicates if the capability is enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;

    /// <summary>
    /// Determines the metafield definition's filter status for use in admin filtering.
    /// </summary>
    [JsonPropertyName("status")]
    public MetafieldDefinitionAdminFilterStatus? status { get; set; } = null;
}