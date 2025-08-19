#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A configured metafield definition validation.
/// For example, for a metafield definition of `number_integer` type, you can set a validation with the name `max`
/// and a value of `15`. This validation will ensure that the value of the metafield is a number less than or equal to 15.
/// Refer to the [list of supported validations](https://shopify.dev/api/admin/graphql/reference/common-objects/metafieldDefinitionTypes#examples-Fetch_all_metafield_definition_types).
/// </summary>
public record MetafieldDefinitionValidation : IGraphQLObject
{
    /// <summary>
    /// The validation name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The name for the metafield type of this validation.
    /// </summary>
    [JsonPropertyName("type")]
    public string? type { get; set; } = null;

    /// <summary>
    /// The validation value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}