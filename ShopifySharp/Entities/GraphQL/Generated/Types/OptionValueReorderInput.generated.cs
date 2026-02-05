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
/// The input fields for reordering a product option value.
/// </summary>
public record OptionValueReorderInput : GraphQLInputObject<OptionValueReorderInput>
{
    /// <summary>
    /// Specifies the product option value by ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Specifies the product option value by name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}