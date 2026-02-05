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
/// The value of a fixed amount price rule.
/// </summary>
public record PriceRuleFixedAmountValue : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The monetary value of the price rule.
    /// </summary>
    [JsonPropertyName("amount")]
    public decimal? amount { get; set; } = null;
}