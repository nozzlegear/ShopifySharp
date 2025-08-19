#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to create order transactions when refunding a return.
/// </summary>
public record ReturnRefundOrderTransactionInput : GraphQLInputObject<ReturnRefundOrderTransactionInput>
{
    /// <summary>
    /// The ID of the parent order transaction. The transaction must be of kind `CAPTURE` or a `SALE`.
    /// </summary>
    [JsonPropertyName("parentId")]
    public string? parentId { get; set; } = null;

    /// <summary>
    /// The amount of money for the transaction in the presentment currency of the order.
    /// </summary>
    [JsonPropertyName("transactionAmount")]
    public MoneyInput? transactionAmount { get; set; } = null;
}