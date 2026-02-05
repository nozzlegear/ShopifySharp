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
/// The input fields for the selected variant option of the combined listing.
/// </summary>
public record SelectedVariantOptionInput : GraphQLInputObject<SelectedVariantOptionInput>
{
    /// <summary>
    /// The metaobject value of the linked metafield.
    /// </summary>
    [JsonPropertyName("linkedMetafieldValue")]
    public string? linkedMetafieldValue { get; set; } = null;

    /// <summary>
    /// The name of the parent product's option.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The selected option value of the parent product's option.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}