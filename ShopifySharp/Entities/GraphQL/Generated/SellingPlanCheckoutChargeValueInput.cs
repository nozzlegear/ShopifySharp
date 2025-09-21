#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to create or update an checkout charge value.
/// </summary>
public record SellingPlanCheckoutChargeValueInput : GraphQLInputObject<SellingPlanCheckoutChargeValueInput>
{
    /// <summary>
    /// The fixed value for an checkout charge.
    /// </summary>
    [JsonPropertyName("fixedValue")]
    public decimal? fixedValue { get; set; } = null;

    /// <summary>
    /// The percentage value.
    /// </summary>
    [JsonPropertyName("percentage")]
    public decimal? percentage { get; set; } = null;
}