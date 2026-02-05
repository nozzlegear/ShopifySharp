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
/// The actual amount discounted on a line item or shipping line. While [`DiscountApplication`](https://shopify.dev/docs/api/admin-graphql/latest/interfaces/DiscountApplication)
/// captures the discount's intentions and rules, The `DiscountAllocation` object
/// shows the final calculated discount amount applied to each line.
/// The allocation includes the discounted amount in both shop and presentment
/// currencies, with a reference to the originating discount application.
/// </summary>
public record DiscountAllocation : IGraphQLObject
{
    /// <summary>
    /// The money amount that's allocated to a line based on the associated discount application.
    /// </summary>
    [JsonPropertyName("allocatedAmount")]
    [Obsolete("Use `allocatedAmountSet` instead.")]
    public MoneyV2? allocatedAmount { get; set; } = null;

    /// <summary>
    /// The money amount that's allocated to a line based on the associated discount
    /// application in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("allocatedAmountSet")]
    public MoneyBag? allocatedAmountSet { get; set; } = null;

    /// <summary>
    /// The discount application that the allocated amount originated from.
    /// </summary>
    [JsonPropertyName("discountApplication")]
    public IDiscountApplication? discountApplication { get; set; } = null;
}