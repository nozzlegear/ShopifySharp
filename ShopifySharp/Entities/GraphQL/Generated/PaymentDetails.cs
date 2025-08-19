#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Payment details related to a transaction.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(CardPaymentDetails), typeDiscriminator: "CardPaymentDetails")]
[JsonDerivedType(typeof(LocalPaymentMethodsPaymentDetails), typeDiscriminator: "LocalPaymentMethodsPaymentDetails")]
[JsonDerivedType(typeof(PaypalWalletPaymentDetails), typeDiscriminator: "PaypalWalletPaymentDetails")]
[JsonDerivedType(typeof(ShopPayInstallmentsPaymentDetails), typeDiscriminator: "ShopPayInstallmentsPaymentDetails")]
public record PaymentDetails : GraphQLObject<PaymentDetails>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public CardPaymentDetails? AsCardPaymentDetails() => this is PaymentDetailsCardPaymentDetails wrapper ? wrapper.Value : null;
	public LocalPaymentMethodsPaymentDetails? AsLocalPaymentMethodsPaymentDetails() => this is PaymentDetailsLocalPaymentMethodsPaymentDetails wrapper ? wrapper.Value : null;
	public PaypalWalletPaymentDetails? AsPaypalWalletPaymentDetails() => this is PaymentDetailsPaypalWalletPaymentDetails wrapper ? wrapper.Value : null;
	public ShopPayInstallmentsPaymentDetails? AsShopPayInstallmentsPaymentDetails() => this is PaymentDetailsShopPayInstallmentsPaymentDetails wrapper ? wrapper.Value : null;
#endif
}