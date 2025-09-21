#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a restocking fee.
/// </summary>
public record RestockingFeeInput : GraphQLInputObject<RestockingFeeInput>
{
    /// <summary>
    /// The value of the fee as a percentage.
    /// </summary>
    [JsonPropertyName("percentage")]
    public decimal? percentage { get; set; } = null;
}