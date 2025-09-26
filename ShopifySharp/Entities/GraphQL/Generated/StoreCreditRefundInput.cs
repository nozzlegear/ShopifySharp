#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to process a refund to store credit.
/// </summary>
public record StoreCreditRefundInput : GraphQLInputObject<StoreCreditRefundInput>
{
    /// <summary>
    /// The amount to be issued as store credit.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyInput? amount { get; set; } = null;

    /// <summary>
    /// An optional expiration date for the store credit being issued.
    /// </summary>
    [JsonPropertyName("expiresAt")]
    public DateTime? expiresAt { get; set; } = null;
}