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