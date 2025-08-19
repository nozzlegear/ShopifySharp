#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `orderEditRemoveLineItemDiscount` mutation.
/// </summary>
public record OrderEditRemoveLineItemDiscountPayload : IGraphQLObject
{
    /// <summary>
    /// The calculated line item after removal of the discount.
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