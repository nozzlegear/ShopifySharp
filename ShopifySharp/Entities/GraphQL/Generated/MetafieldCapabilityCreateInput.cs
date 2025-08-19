#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for creating a metafield capability.
/// </summary>
public record MetafieldCapabilityCreateInput : GraphQLInputObject<MetafieldCapabilityCreateInput>
{
    /// <summary>
    /// The input for updating the admin filterable capability.
    /// </summary>
    [JsonPropertyName("adminFilterable")]
    public MetafieldCapabilityAdminFilterableInput? adminFilterable { get; set; } = null;

    /// <summary>
    /// The input for updating the smart collection condition capability.
    /// </summary>
    [JsonPropertyName("smartCollectionCondition")]
    public MetafieldCapabilitySmartCollectionConditionInput? smartCollectionCondition { get; set; } = null;

    /// <summary>
    /// The input for updating the unique values capability.
    /// </summary>
    [JsonPropertyName("uniqueValues")]
    public MetafieldCapabilityUniqueValuesInput? uniqueValues { get; set; } = null;
}