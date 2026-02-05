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
/// The input fields for updating a product option.
/// </summary>
public record OptionUpdateInput : GraphQLInputObject<OptionUpdateInput>
{
    /// <summary>
    /// Specifies the product option to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Specifies the metafield the option is linked to.
    /// </summary>
    [JsonPropertyName("linkedMetafield")]
    public LinkedMetafieldUpdateInput? linkedMetafield { get; set; } = null;

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
}