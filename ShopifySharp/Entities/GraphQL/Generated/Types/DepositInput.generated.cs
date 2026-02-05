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
/// The input fields configuring the deposit for a B2B buyer.
/// </summary>
public record DepositInput : GraphQLInputObject<DepositInput>
{
    /// <summary>
    /// The percentage of the order total that should be paid as a deposit. Must be between 1 and 99, inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public decimal? percentage { get; set; } = null;
}