#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields representing the components of a bundle line item.
/// </summary>
public record BundlesDraftOrderBundleLineItemComponentInput : GraphQLInputObject<BundlesDraftOrderBundleLineItemComponentInput>
{
    /// <summary>
    /// The quantity of the bundle component.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The UUID of the bundle component. Must be unique and consistent across requests.
    /// This field is mandatory in order to manipulate drafts with bundles.
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? uuid { get; set; } = null;

    /// <summary>
    /// The ID of the product variant corresponding to the bundle component.
    /// </summary>
    [JsonPropertyName("variantId")]
    public string? variantId { get; set; } = null;
}