#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for the financial transfer for the return.
/// </summary>
public record ReturnProcessFinancialTransferInput : GraphQLInputObject<ReturnProcessFinancialTransferInput>
{
    /// <summary>
    /// Issue a refund for the return.
    /// </summary>
    [JsonPropertyName("issueRefund")]
    public ReturnProcessRefundInput? issueRefund { get; set; } = null;
}