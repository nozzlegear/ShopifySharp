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
/// The input fields for the refund for the return.
/// </summary>
public record ReturnProcessRefundInput : GraphQLInputObject<ReturnProcessRefundInput>
{
    /// <summary>
    /// Whether to allow the total refunded amount to surpass the amount paid for the order.
    /// </summary>
    [JsonPropertyName("allowOverRefunding")]
    public bool? allowOverRefunding { get; set; } = null;

    /// <summary>
    /// The order transactions for the refund.
    /// </summary>
    [JsonPropertyName("orderTransactions")]
    public ICollection<ReturnRefundOrderTransactionInput>? orderTransactions { get; set; } = null;

    /// <summary>
    /// A list of instructions to process the financial outcome of the refund.
    /// </summary>
    [JsonPropertyName("refundMethods")]
    public ICollection<RefundMethodInput>? refundMethods { get; set; } = null;
}