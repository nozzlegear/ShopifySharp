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
/// A metafield definition type provides basic foundation and validation for a metafield.
/// </summary>
public record MetafieldDefinitionType : IGraphQLObject
{
    /// <summary>
    /// The category associated with the metafield definition type.
    /// </summary>
    [JsonPropertyName("category")]
    public string? category { get; set; } = null;

    /// <summary>
    /// The name of the type for the metafield definition.
    /// See the list of [supported types](https://shopify.dev/apps/metafields/types).
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The supported validations for a metafield definition type.
    /// </summary>
    [JsonPropertyName("supportedValidations")]
    public ICollection<MetafieldDefinitionSupportedValidation>? supportedValidations { get; set; } = null;

    /// <summary>
    /// Whether metafields without a definition can be migrated to a definition of this type.
    /// </summary>
    [JsonPropertyName("supportsDefinitionMigrations")]
    public bool? supportsDefinitionMigrations { get; set; } = null;

    /// <summary>
    /// The value type for a metafield created with this definition type.
    /// </summary>
    [JsonPropertyName("valueType")]
    [Obsolete("`valueType` is deprecated and `name` should be used for type information.")]
    public MetafieldValueType? valueType { get; set; } = null;
}