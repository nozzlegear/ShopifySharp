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
/// The input fields for identifying a location.
/// </summary>
public record LocationIdentifierInput : GraphQLInputObject<LocationIdentifierInput>
{
    /// <summary>
    /// The [custom ID](https://shopify.dev/docs/apps/build/custom-data/metafields/working-with-custom-ids) of the location.
    /// </summary>
    [JsonPropertyName("customId")]
    public UniqueMetafieldValueInput? customId { get; set; } = null;

    /// <summary>
    /// The ID of the location.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}