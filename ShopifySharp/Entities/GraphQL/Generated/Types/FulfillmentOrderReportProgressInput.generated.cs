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
/// The input fields for the progress report for the fulfillment order.
/// </summary>
public record FulfillmentOrderReportProgressInput : GraphQLInputObject<FulfillmentOrderReportProgressInput>
{
    /// <summary>
    /// Additional information for the progress report.
    /// </summary>
    [JsonPropertyName("reasonNotes")]
    public string? reasonNotes { get; set; } = null;
}