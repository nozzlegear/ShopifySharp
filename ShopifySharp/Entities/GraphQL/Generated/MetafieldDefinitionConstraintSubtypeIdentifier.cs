#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to identify a subtype of a resource for the purposes of metafield definition constraints.
/// </summary>
public record MetafieldDefinitionConstraintSubtypeIdentifier : GraphQLInputObject<MetafieldDefinitionConstraintSubtypeIdentifier>
{
    /// <summary>
    /// The category of the resource subtype.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The specific subtype value within the identified subtype category.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}