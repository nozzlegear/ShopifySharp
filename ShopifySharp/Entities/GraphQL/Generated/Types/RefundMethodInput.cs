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
/// The input fields for processing the financial outcome of a refund.
/// </summary>
public record RefundMethodInput : GraphQLInputObject<RefundMethodInput>
{
    /// <summary>
    /// The details of the refund to store credit.
    /// </summary>
    [JsonPropertyName("storeCreditRefund")]
    public StoreCreditRefundInput? storeCreditRefund { get; set; } = null;
}