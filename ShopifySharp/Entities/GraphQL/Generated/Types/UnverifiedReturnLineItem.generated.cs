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
/// An unverified return line item.
/// </summary>
public record UnverifiedReturnLineItem : IGraphQLObject, INode, IReturnLineItemType
{
    /// <summary>
    /// A note from the customer that describes the item to be returned. Maximum length: 300 characters.
    /// </summary>
    [JsonPropertyName("customerNote")]
    public string? customerNote { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The quantity that can be processed.
    /// </summary>
    [JsonPropertyName("processableQuantity")]
    public int? processableQuantity { get; set; } = null;

    /// <summary>
    /// The quantity that has been processed.
    /// </summary>
    [JsonPropertyName("processedQuantity")]
    public int? processedQuantity { get; set; } = null;

    /// <summary>
    /// The quantity being returned.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The quantity that can be refunded.
    /// </summary>
    [JsonPropertyName("refundableQuantity")]
    public int? refundableQuantity { get; set; } = null;

    /// <summary>
    /// The quantity that was refunded.
    /// </summary>
    [JsonPropertyName("refundedQuantity")]
    public int? refundedQuantity { get; set; } = null;

    /// <summary>
    /// The reason for returning the item.
    /// </summary>
    [JsonPropertyName("returnReason")]
    [Obsolete("Use `returnReasonDefinition` instead. This field will be removed in the future.")]
    public ReturnReason? returnReason { get; set; } = null;

    /// <summary>
    /// The standardized reason for why the item is being returned.
    /// </summary>
    [JsonPropertyName("returnReasonDefinition")]
    public ReturnReasonDefinition? returnReasonDefinition { get; set; } = null;

    /// <summary>
    /// Additional information about the reason for the return. Maximum length: 255 characters.
    /// </summary>
    [JsonPropertyName("returnReasonNote")]
    public string? returnReasonNote { get; set; } = null;

    /// <summary>
    /// The unit price of the unverified return line item.
    /// </summary>
    [JsonPropertyName("unitPrice")]
    public MoneyV2? unitPrice { get; set; } = null;

    /// <summary>
    /// The quantity that has't been processed.
    /// </summary>
    [JsonPropertyName("unprocessedQuantity")]
    public int? unprocessedQuantity { get; set; } = null;
}