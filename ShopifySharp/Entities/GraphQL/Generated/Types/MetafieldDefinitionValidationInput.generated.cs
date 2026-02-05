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
/// The name and value for a metafield definition validation.
/// For example, for a metafield definition of `single_line_text_field` type, you
/// can set a validation with the name `min` and a value of `10`.
/// This validation will ensure that the value of the metafield is at least 10 characters.
/// Refer to the [list of supported validations](https://shopify.dev/apps/build/custom-data/metafields/list-of-validation-options).
/// </summary>
public record MetafieldDefinitionValidationInput : GraphQLInputObject<MetafieldDefinitionValidationInput>
{
    /// <summary>
    /// The name for the metafield definition validation.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The value for the metafield definition validation.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}