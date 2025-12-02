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
/// The input fields for reordering a product option and/or its values.
/// </summary>
public record OptionReorderInput : GraphQLInputObject<OptionReorderInput>
{
    /// <summary>
    /// Specifies the product option to reorder by ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Specifies the product option to reorder by name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Values associated with the option.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<OptionValueReorderInput>? values { get; set; } = null;
}