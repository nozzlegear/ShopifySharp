#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a single option related to a component product.
/// </summary>
public record ProductBundleComponentOptionSelectionInput : GraphQLInputObject<ProductBundleComponentOptionSelectionInput>
{
    /// <summary>
    /// The ID of the option present on the component product.
    /// </summary>
    [JsonPropertyName("componentOptionId")]
    public string? componentOptionId { get; set; } = null;

    /// <summary>
    /// The name to create for this option on the parent product.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Array of selected option values.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<string>? values { get; set; } = null;
}