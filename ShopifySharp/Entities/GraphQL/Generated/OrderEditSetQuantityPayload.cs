#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `orderEditSetQuantity` mutation.
/// </summary>
public record OrderEditSetQuantityPayload : IGraphQLObject
{
    /// <summary>
    /// The calculated line item with the edits applied but not saved.
    /// </summary>
    [JsonPropertyName("calculatedLineItem")]
    public CalculatedLineItem? calculatedLineItem { get; set; } = null;

    /// <summary>
    /// The calculated order with the edits applied but not saved.
    /// </summary>
    [JsonPropertyName("calculatedOrder")]
    public CalculatedOrder? calculatedOrder { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}