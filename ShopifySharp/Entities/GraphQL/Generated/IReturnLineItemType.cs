#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A return line item of any type.
/// </summary>
public interface IReturnLineItemType : IGraphQLObject
{
    /// <summary>
    /// A note from the customer that describes the item to be returned. Maximum length: 300 characters.
    /// </summary>
    [JsonPropertyName("customerNote")]
    public string? customerNote { get; set; }

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }

    /// <summary>
    /// The quantity that can be processed.
    /// </summary>
    [JsonPropertyName("processableQuantity")]
    public int? processableQuantity { get; set; }

    /// <summary>
    /// The quantity that has been processed.
    /// </summary>
    [JsonPropertyName("processedQuantity")]
    public int? processedQuantity { get; set; }

    /// <summary>
    /// The quantity being returned.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; }

    /// <summary>
    /// The quantity that can be refunded.
    /// </summary>
    [JsonPropertyName("refundableQuantity")]
    public int? refundableQuantity { get; set; }

    /// <summary>
    /// The quantity that was refunded.
    /// </summary>
    [JsonPropertyName("refundedQuantity")]
    public int? refundedQuantity { get; set; }

    /// <summary>
    /// The reason for returning the item.
    /// </summary>
    [JsonPropertyName("returnReason")]
    public ReturnReason? returnReason { get; set; }

    /// <summary>
    /// Additional information about the reason for the return. Maximum length: 255 characters.
    /// </summary>
    [JsonPropertyName("returnReasonNote")]
    public string? returnReasonNote { get; set; }

    /// <summary>
    /// The quantity that has't been processed.
    /// </summary>
    [JsonPropertyName("unprocessedQuantity")]
    public int? unprocessedQuantity { get; set; }
}