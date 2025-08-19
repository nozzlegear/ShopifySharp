#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A percentage deposit.
/// </summary>
public record DepositPercentage : DepositConfiguration, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The percentage value of the deposit.
    /// </summary>
    [JsonPropertyName("percentage")]
    public decimal? percentage { get; set; } = null;
}