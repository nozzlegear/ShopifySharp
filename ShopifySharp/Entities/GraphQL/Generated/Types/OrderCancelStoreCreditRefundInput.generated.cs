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
/// The input fields used to refund to store credit.
/// </summary>
public record OrderCancelStoreCreditRefundInput : GraphQLInputObject<OrderCancelStoreCreditRefundInput>
{
    /// <summary>
    /// The expiration date of the store credit.
    /// </summary>
    [JsonPropertyName("expiresAt")]
    public DateTimeOffset? expiresAt { get; set; } = null;
}