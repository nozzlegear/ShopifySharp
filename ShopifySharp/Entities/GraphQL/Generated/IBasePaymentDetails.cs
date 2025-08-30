#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Generic payment details that are related to a transaction.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(CardPaymentDetails), typeDiscriminator: "CardPaymentDetails")]
[JsonDerivedType(typeof(LocalPaymentMethodsPaymentDetails), typeDiscriminator: "LocalPaymentMethodsPaymentDetails")]
[JsonDerivedType(typeof(PaypalWalletPaymentDetails), typeDiscriminator: "PaypalWalletPaymentDetails")]
[JsonDerivedType(typeof(ShopPayInstallmentsPaymentDetails), typeDiscriminator: "ShopPayInstallmentsPaymentDetails")]
public interface IBasePaymentDetails : IGraphQLObject
{
    /// <summary>
    /// The name of payment method used by the buyer.
    /// </summary>
    [JsonPropertyName("paymentMethodName")]
    public string? paymentMethodName { get; set; }
}