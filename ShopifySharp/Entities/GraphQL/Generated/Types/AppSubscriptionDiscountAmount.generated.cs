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
/// The fixed amount value of a discount.
/// </summary>
public record AppSubscriptionDiscountAmount : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The fixed amount value of a discount.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyV2? amount { get; set; } = null;
}