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
/// The order-level discount applied to a draft order.
/// </summary>
public record DraftOrderAppliedDiscount : IGraphQLObject
{
    /// <summary>
    /// Amount of the order-level discount that's applied to the draft order in shop currency.
    /// </summary>
    [JsonPropertyName("amount")]
    [Obsolete("Use `amountSet` instead.")]
    public decimal? amount { get; set; } = null;

    /// <summary>
    /// The amount of money discounted, with values shown in both shop currency and presentment currency.
    /// </summary>
    [JsonPropertyName("amountSet")]
    public MoneyBag? amountSet { get; set; } = null;

    /// <summary>
    /// Amount of money discounted.
    /// </summary>
    [JsonPropertyName("amountV2")]
    [Obsolete("Use `amountSet` instead.")]
    public MoneyV2? amountV2 { get; set; } = null;

    /// <summary>
    /// Description of the order-level discount.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// Name of the order-level discount.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The order level discount amount. If `valueType` is `"percentage"`,
    /// then `value` is the percentage discount.
    /// </summary>
    [JsonPropertyName("value")]
    public decimal? @value { get; set; } = null;

    /// <summary>
    /// Type of the order-level discount.
    /// </summary>
    [JsonPropertyName("valueType")]
    public DraftOrderAppliedDiscountType? valueType { get; set; } = null;
}