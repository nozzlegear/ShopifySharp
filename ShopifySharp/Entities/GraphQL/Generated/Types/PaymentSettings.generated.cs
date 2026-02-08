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