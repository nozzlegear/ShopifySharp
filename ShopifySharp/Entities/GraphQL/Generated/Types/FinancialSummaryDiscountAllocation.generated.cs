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
/// An amount that's allocated to a line item based on an associated discount application.
/// </summary>
public record FinancialSummaryDiscountAllocation : IGraphQLObject
{
    /// <summary>
    /// The money amount that's allocated per unit on the associated line based on the
    /// discount application in shop and presentment currencies. If the allocated
    /// amount for the line cannot be evenly divided by the quantity, then this amount
    /// will be an approximate amount, avoiding fractional pennies. For example, if
    /// the associated line had a quantity of 3 with a discount of 4 cents, then the
    /// discount distribution would be [0.01, 0.01, 0.02]. This field returns the
    /// highest number of the distribution. In this example, this would be 0.02.
    /// </summary>
    [JsonPropertyName("approximateAllocatedAmountPerItem")]
    public MoneyBag? approximateAllocatedAmountPerItem { get; set; } = null;

    /// <summary>
    /// The discount application that the allocated amount originated from.
    /// </summary>
    [JsonPropertyName("discountApplication")]
    public FinancialSummaryDiscountApplication? discountApplication { get; set; } = null;
}