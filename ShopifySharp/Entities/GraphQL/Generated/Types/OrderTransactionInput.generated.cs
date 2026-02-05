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
/// The input fields for the information needed to create an order transaction.
/// </summary>
public record OrderTransactionInput : GraphQLInputObject<OrderTransactionInput>
{
    /// <summary>
    /// The amount of money for this transaction.
    /// </summary>
    [JsonPropertyName("amount")]
    public decimal? amount { get; set; } = null;

    /// <summary>
    /// The payment gateway to use for this transaction.
    /// </summary>
    [JsonPropertyName("gateway")]
    public string? gateway { get; set; } = null;

    /// <summary>
    /// The kind of transaction.
    /// </summary>
    [JsonPropertyName("kind")]
    public OrderTransactionKind? kind { get; set; } = null;

    /// <summary>
    /// The ID of the order associated with the transaction.
    /// </summary>
    [JsonPropertyName("orderId")]
    public string? orderId { get; set; } = null;

    /// <summary>
    /// The ID of the optional parent transaction, for example the authorization of a capture.
    /// </summary>
    [JsonPropertyName("parentId")]
    public string? parentId { get; set; } = null;
}