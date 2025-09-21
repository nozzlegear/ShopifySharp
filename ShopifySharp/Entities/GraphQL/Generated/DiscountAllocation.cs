#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// An amount that's allocated to a line based on an associated discount application.
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