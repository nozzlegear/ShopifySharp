#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `orderEditRemoveShippingLine` mutation.
/// </summary>
public record OrderEditRemoveShippingLinePayload : IGraphQLObject
{
    /// <summary>
    /// The [calculated order](https://shopify.dev/api/admin-graphql/latest/objects/calculatedorder)
    /// with the edits applied but not saved.
    /// </summary>
    [JsonPropertyName("calculatedOrder")]
    public CalculatedOrder? calculatedOrder { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<OrderEditRemoveShippingLineUserError>? userErrors { get; set; } = null;
}