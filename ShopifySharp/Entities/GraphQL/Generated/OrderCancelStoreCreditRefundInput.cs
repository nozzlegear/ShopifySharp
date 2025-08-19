#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to refund to store credit.
/// </summary>
public record OrderCancelStoreCreditRefundInput : GraphQLInputObject<OrderCancelStoreCreditRefundInput>
{
    /// <summary>
    /// The expiration date of the store credit.
    /// </summary>
    [JsonPropertyName("expiresAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? expiresAt { get; set; } = null;
}