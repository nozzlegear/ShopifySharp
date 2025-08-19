#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The international duties relevant to a fulfillment order.
/// </summary>
public record FulfillmentOrderInternationalDuties : IGraphQLObject
{
    /// <summary>
    /// The method of duties payment. Example values: `DDP`, `DAP`.
    /// </summary>
    [JsonPropertyName("incoterm")]
    public string? incoterm { get; set; } = null;
}