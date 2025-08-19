#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `orderEditRemoveDiscount` mutation.
/// </summary>
public record OrderEditRemoveDiscountPayload : IGraphQLObject
{
    /// <summary>
    /// An order with the edits applied but not saved.
    /// </summary>
    [JsonPropertyName("calculatedOrder")]
    public CalculatedOrder? calculatedOrder { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<OrderEditRemoveDiscountUserError>? userErrors { get; set; } = null;
}