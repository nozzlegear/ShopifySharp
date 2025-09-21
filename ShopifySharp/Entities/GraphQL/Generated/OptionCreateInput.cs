#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for creating a product option.
/// </summary>
public record OptionCreateInput : GraphQLInputObject<OptionCreateInput>
{
    /// <summary>
    /// Specifies the metafield the option is linked to.
    /// </summary>
    [JsonPropertyName("linkedMetafield")]
    public LinkedMetafieldCreateInput? linkedMetafield { get; set; } = null;

    /// <summary>
    /// Name of the option.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Position of the option.
    /// </summary>
    [JsonPropertyName("position")]
    public int? position { get; set; } = null;

    /// <summary>
    /// Values associated with the option.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<OptionValueCreateInput>? values { get; set; } = null;
}