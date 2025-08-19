#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Settings related to payments.
/// </summary>
public record PaymentSettings : IGraphQLObject
{
    /// <summary>
    /// List of the digital wallets which the shop supports.
    /// </summary>
    [JsonPropertyName("supportedDigitalWallets")]
    public ICollection<DigitalWallet>? supportedDigitalWallets { get; set; } = null;
}