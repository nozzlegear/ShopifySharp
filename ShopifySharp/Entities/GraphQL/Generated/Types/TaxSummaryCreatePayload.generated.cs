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
/// Return type for `taxSummaryCreate` mutation.
/// </summary>
public record TaxSummaryCreatePayload : IGraphQLObject
{
    /// <summary>
    /// A list of orders that were successfully enqueued to create a tax summary.
    /// </summary>
    [JsonPropertyName("enqueuedOrders")]
    public ICollection<Order>? enqueuedOrders { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<TaxSummaryCreateUserError>? userErrors { get; set; } = null;
}