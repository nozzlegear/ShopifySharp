#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A customer's payment method.
/// </summary>
public record CustomerPaymentMethod : IGraphQLObject, INode
{
    /// <summary>
    /// The customer to whom the payment method belongs.
    /// </summary>
    [JsonPropertyName("customer")]
    public Customer? customer { get; set; } = null;

    /// <summary>
    /// The ID of this payment method.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The instrument for this payment method.
    /// </summary>
    [JsonPropertyName("instrument")]
    public CustomerPaymentInstrument? instrument { get; set; } = null;

    /// <summary>
    /// The time that the payment method was revoked.
    /// </summary>
    [JsonPropertyName("revokedAt")]
    public DateTime? revokedAt { get; set; } = null;

    /// <summary>
    /// The revocation reason for this payment method.
    /// </summary>
    [JsonPropertyName("revokedReason")]
    public CustomerPaymentMethodRevocationReason? revokedReason { get; set; } = null;

    /// <summary>
    /// List Subscription Contracts.
    /// </summary>
    [JsonPropertyName("subscriptionContracts")]
    public SubscriptionContractConnection? subscriptionContracts { get; set; } = null;
}