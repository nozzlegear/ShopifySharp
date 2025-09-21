#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `orderEditAddLineItemDiscount` mutation.
/// </summary>
public record OrderEditAddLineItemDiscountPayload : IGraphQLObject
{
    /// <summary>
    /// The discount applied to a line item during this order edit.
    /// </summary>
    [JsonPropertyName("addedDiscountStagedChange")]
    public OrderStagedChangeAddLineItemDiscount? addedDiscountStagedChange { get; set; } = null;

    /// <summary>
    /// The line item with the edits applied but not saved.
    /// </summary>
    [JsonPropertyName("calculatedLineItem")]
    public CalculatedLineItem? calculatedLineItem { get; set; } = null;

    /// <summary>
    /// An order with the edits applied but not saved.
    /// </summary>
    [JsonPropertyName("calculatedOrder")]
    public CalculatedOrder? calculatedOrder { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}