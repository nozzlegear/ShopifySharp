#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record PaymentDetailsCardPaymentDetails(CardPaymentDetails Value): PaymentDetails;
internal record PaymentDetailsLocalPaymentMethodsPaymentDetails(LocalPaymentMethodsPaymentDetails Value): PaymentDetails;
internal record PaymentDetailsPaypalWalletPaymentDetails(PaypalWalletPaymentDetails Value): PaymentDetails;
internal record PaymentDetailsShopPayInstallmentsPaymentDetails(ShopPayInstallmentsPaymentDetails Value): PaymentDetails;
#endif /// <summary>

/// All possible instrument outputs for Payment Mandates.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(VaultCreditCard), typeDiscriminator: "VaultCreditCard")]
[JsonDerivedType(typeof(VaultPaypalBillingAgreement), typeDiscriminator: "VaultPaypalBillingAgreement")]
public record PaymentInstrument : GraphQLObject<PaymentInstrument>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public VaultCreditCard? AsVaultCreditCard() => this is PaymentInstrumentVaultCreditCard wrapper ? wrapper.Value : null;
	public VaultPaypalBillingAgreement? AsVaultPaypalBillingAgreement() => this is PaymentInstrumentVaultPaypalBillingAgreement wrapper ? wrapper.Value : null;
#endif
}