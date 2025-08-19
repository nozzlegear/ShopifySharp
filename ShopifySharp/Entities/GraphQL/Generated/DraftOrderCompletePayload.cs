#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `draftOrderComplete` mutation.
/// </summary>
public record DraftOrderCompletePayload : IGraphQLObject
{
    /// <summary>
    /// The completed draft order.
    /// </summary>
    [JsonPropertyName("draftOrder")]
    public DraftOrder? draftOrder { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}