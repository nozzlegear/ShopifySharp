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
/// The tax allocated to a sale from a single tax line.
/// </summary>
public record SaleTax : IGraphQLObject
{
    /// <summary>
    /// The portion of the total tax amount on the related sale that comes from the associated tax line.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyBag? amount { get; set; } = null;

    /// <summary>
    /// The unique ID for the sale tax.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The tax line associated with the sale.
    /// </summary>
    [JsonPropertyName("taxLine")]
    public TaxLine? taxLine { get; set; } = null;
}