#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A line item group (bundle) to which a line item belongs to.
/// </summary>
public record LineItemGroup : IGraphQLObject, INode
{
    /// <summary>
    /// A list of attributes that represent custom features or special requests.
    /// </summary>
    [JsonPropertyName("customAttributes")]
    public ICollection<Attribute>? customAttributes { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// ID of the product of the line item group.
    /// </summary>
    [JsonPropertyName("productId")]
    public string? productId { get; set; } = null;

    /// <summary>
    /// Quantity of the line item group on the order.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// Title of the line item group.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// ID of the variant of the line item group.
    /// </summary>
    [JsonPropertyName("variantId")]
    public string? variantId { get; set; } = null;

    /// <summary>
    /// SKU of the variant of the line item group.
    /// </summary>
    [JsonPropertyName("variantSku")]
    public string? variantSku { get; set; } = null;
}