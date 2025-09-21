#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `orderEditAddShippingLine` mutation.
/// </summary>
public record OrderEditAddShippingLinePayload : IGraphQLObject
{
    /// <summary>
    /// The [calculated order](https://shopify.dev/api/admin-graphql/latest/objects/calculatedorder)
    /// with the edits applied but not saved.
    /// </summary>
    [JsonPropertyName("calculatedOrder")]
    public CalculatedOrder? calculatedOrder { get; set; } = null;

    /// <summary>
    /// The [calculated shipping line](https://shopify.dev/api/admin-graphql/latest/objects/calculatedshippingline)
    /// that's added during this order edit.
    /// </summary>
    [JsonPropertyName("calculatedShippingLine")]
    public CalculatedShippingLine? calculatedShippingLine { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<OrderEditAddShippingLineUserError>? userErrors { get; set; } = null;
}