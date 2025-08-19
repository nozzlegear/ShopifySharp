#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The inputs fields for modifying a metafield definition's constraint subtype values.
/// Exactly one option is required.
/// </summary>
public record MetafieldDefinitionConstraintValueUpdateInput : GraphQLInputObject<MetafieldDefinitionConstraintValueUpdateInput>
{
    /// <summary>
    /// The constraint subtype value to create.
    /// </summary>
    [JsonPropertyName("create")]
    public string? create { get; set; } = null;

    /// <summary>
    /// The constraint subtype value to delete.
    /// </summary>
    [JsonPropertyName("delete")]
    public string? delete { get; set; } = null;
}