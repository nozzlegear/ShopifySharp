#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// An amount discounting the line that has been allocated by an associated discount application.
/// </summary>
public record CalculatedDiscountAllocation : IGraphQLObject
{
    /// <summary>
    /// The money amount that's allocated by the discount application in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("allocatedAmountSet")]
    public MoneyBag? allocatedAmountSet { get; set; } = null;

    /// <summary>
    /// The discount that the allocated amount originated from.
    /// </summary>
    [JsonPropertyName("discountApplication")]
    public ICalculatedDiscountApplication? discountApplication { get; set; } = null;
}