#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A constraint subtype value that the metafield definition applies to.
/// </summary>
public record MetafieldDefinitionConstraintValue : IGraphQLObject
{
    /// <summary>
    /// The subtype value of the constraint.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}