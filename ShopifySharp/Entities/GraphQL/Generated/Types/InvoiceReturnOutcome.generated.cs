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
/// The financial transfer details for a return outcome that results in an invoice.
/// </summary>
public record InvoiceReturnOutcome : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The total monetary value to be invoiced in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyBag? amount { get; set; } = null;
}