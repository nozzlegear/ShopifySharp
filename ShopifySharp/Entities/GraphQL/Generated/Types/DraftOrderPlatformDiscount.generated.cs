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
/// The platform discounts applied to the draft order.
/// </summary>
public record DraftOrderPlatformDiscount : IGraphQLObject
{
    /// <summary>
    /// Price reduction allocations across the draft order's lines.
    /// </summary>
    [JsonPropertyName("allocations")]
    public ICollection<DraftOrderPlatformDiscountAllocation>? allocations { get; set; } = null;

    /// <summary>
    /// Whether the discount is an automatic discount.
    /// </summary>
    [JsonPropertyName("automaticDiscount")]
    public bool? automaticDiscount { get; set; } = null;

    /// <summary>
    /// Whether the discount is a buy x get y discount.
    /// </summary>
    [JsonPropertyName("bxgyDiscount")]
    public bool? bxgyDiscount { get; set; } = null;

    /// <summary>
    /// If a code-based discount, the code used to add the discount.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// The discount class.
    /// </summary>
    [JsonPropertyName("discountClass")]
    [Obsolete("Use `discountClasses` instead.")]
    public DiscountClass? discountClass { get; set; } = null;

    /// <summary>
    /// The discount classes.
    /// </summary>
    [JsonPropertyName("discountClasses")]
    public ICollection<DiscountClass>? discountClasses { get; set; } = null;

    /// <summary>
    /// The discount node for the platform discount.
    /// </summary>
    [JsonPropertyName("discountNode")]
    public DiscountNode? discountNode { get; set; } = null;

    /// <summary>
    /// The ID of the discount.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether the discount is line, order or shipping level.
    /// </summary>
    [JsonPropertyName("presentationLevel")]
    public string? presentationLevel { get; set; } = null;

    /// <summary>
    /// The short summary of the discount.
    /// </summary>
    [JsonPropertyName("shortSummary")]
    public string? shortSummary { get; set; } = null;

    /// <summary>
    /// The summary of the discount.
    /// </summary>
    [JsonPropertyName("summary")]
    public string? summary { get; set; } = null;

    /// <summary>
    /// The name of the discount.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The discount total amount in shop currency.
    /// </summary>
    [JsonPropertyName("totalAmount")]
    public MoneyV2? totalAmount { get; set; } = null;

    /// <summary>
    /// The amount of money discounted, with values shown in both shop currency and presentment currency.
    /// </summary>
    [JsonPropertyName("totalAmountPriceSet")]
    public MoneyBag? totalAmountPriceSet { get; set; } = null;
}