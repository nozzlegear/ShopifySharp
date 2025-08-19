#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record DepositConfigurationDepositPercentage(DepositPercentage Value): DepositConfiguration;
#endif /// <summary>

/// The input fields configuring the deposit for a B2B buyer.
/// </summary>
public record DepositInput : GraphQLInputObject<DepositInput>
{
    /// <summary>
    /// The percentage of the order total that should be paid as a deposit.
    /// </summary>
    [JsonPropertyName("percentage")]
    public decimal? percentage { get; set; } = null;
}