#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a return shipping fee.
/// </summary>
public record ReturnShippingFeeInput : GraphQLInputObject<ReturnShippingFeeInput>
{
    /// <summary>
    /// The value of the fee as a fixed amount in the presentment currency of the order.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyInput? amount { get; set; } = null;
}