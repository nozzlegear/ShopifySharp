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