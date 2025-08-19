#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for identifying a order.
/// </summary>
public record OrderIdentifierInput : GraphQLInputObject<OrderIdentifierInput>
{
    /// <summary>
    /// The [custom ID](https://shopify.dev/docs/apps/build/custom-data/metafields/working-with-custom-ids) of the order.
    /// </summary>
    [JsonPropertyName("customId")]
    public UniqueMetafieldValueInput? customId { get; set; } = null;

    /// <summary>
    /// The ID of the order.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}