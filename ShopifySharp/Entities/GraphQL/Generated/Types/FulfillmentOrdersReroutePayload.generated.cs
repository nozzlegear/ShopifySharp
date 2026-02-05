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
/// Return type for `fulfillmentOrdersReroute` mutation.
/// </summary>
public record FulfillmentOrdersReroutePayload : IGraphQLObject
{
    /// <summary>
    /// The fulfillment orders which contains the moved line items.
    /// </summary>
    [JsonPropertyName("movedFulfillmentOrders")]
    public ICollection<FulfillmentOrder>? movedFulfillmentOrders { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<FulfillmentOrdersRerouteUserError>? userErrors { get; set; } = null;
}