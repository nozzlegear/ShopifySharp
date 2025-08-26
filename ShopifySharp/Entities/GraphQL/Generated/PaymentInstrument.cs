#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// All possible instrument outputs for Payment Mandates.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(PaymentInstrumentVaultCreditCard), typeDiscriminator: "VaultCreditCard")]
[JsonDerivedType(typeof(PaymentInstrumentVaultPaypalBillingAgreement), typeDiscriminator: "VaultPaypalBillingAgreement")]
public record PaymentInstrument : GraphQLObject<PaymentInstrument>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public VaultCreditCard? AsVaultCreditCard() => this is PaymentInstrumentVaultCreditCard wrapper ? wrapper.Value : null;
	public VaultPaypalBillingAgreement? AsVaultPaypalBillingAgreement() => this is PaymentInstrumentVaultPaypalBillingAgreement wrapper ? wrapper.Value : null;
#endif
}