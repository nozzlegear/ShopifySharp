#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A payment instrument and the permission
/// the owner of the instrument gives to the merchant to debit it.
/// </summary>
public record PaymentMandate : IGraphQLObject, INode
{
    /// <summary>
    /// The unique ID of a payment mandate.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The outputs details of the payment instrument.
    /// </summary>
    [JsonPropertyName("paymentInstrument")]
    public PaymentInstrument? paymentInstrument { get; set; } = null;
}