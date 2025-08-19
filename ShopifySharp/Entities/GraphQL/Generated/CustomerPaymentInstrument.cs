#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// All possible instruments for CustomerPaymentMethods.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(CustomerCreditCard), typeDiscriminator: "CustomerCreditCard")]
[JsonDerivedType(typeof(CustomerPaypalBillingAgreement), typeDiscriminator: "CustomerPaypalBillingAgreement")]
[JsonDerivedType(typeof(CustomerShopPayAgreement), typeDiscriminator: "CustomerShopPayAgreement")]
public record CustomerPaymentInstrument : GraphQLObject<CustomerPaymentInstrument>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public CustomerCreditCard? AsCustomerCreditCard() => this is CustomerPaymentInstrumentCustomerCreditCard wrapper ? wrapper.Value : null;
	public CustomerPaypalBillingAgreement? AsCustomerPaypalBillingAgreement() => this is CustomerPaymentInstrumentCustomerPaypalBillingAgreement wrapper ? wrapper.Value : null;
	public CustomerShopPayAgreement? AsCustomerShopPayAgreement() => this is CustomerPaymentInstrumentCustomerShopPayAgreement wrapper ? wrapper.Value : null;
#endif
}