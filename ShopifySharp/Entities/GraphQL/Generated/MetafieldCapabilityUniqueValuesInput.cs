#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for enabling and disabling the unique values capability.
/// </summary>
public record MetafieldCapabilityUniqueValuesInput : GraphQLInputObject<MetafieldCapabilityUniqueValuesInput>
{
    /// <summary>
    /// Indicates whether the capability should be enabled or disabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;
}