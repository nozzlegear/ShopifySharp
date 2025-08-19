#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields representing the components of a line item.
/// </summary>
public record DraftOrderLineItemComponentInput : GraphQLInputObject<DraftOrderLineItemComponentInput>
{
    /// <summary>
    /// The quantity of the component.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The UUID of the component. Must be unique and consistent across requests.
    /// This field is mandatory in order to manipulate drafts with parent line items.
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? uuid { get; set; } = null;

    /// <summary>
    /// The ID of the product variant corresponding to the component.
    /// </summary>
    [JsonPropertyName("variantId")]
    public string? variantId { get; set; } = null;
}