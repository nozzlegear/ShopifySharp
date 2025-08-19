#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `draftOrderCalculate` mutation.
/// </summary>
public record DraftOrderCalculatePayload : IGraphQLObject
{
    /// <summary>
    /// The calculated properties for a draft order.
    /// </summary>
    [JsonPropertyName("calculatedDraftOrder")]
    public CalculatedDraftOrder? calculatedDraftOrder { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}