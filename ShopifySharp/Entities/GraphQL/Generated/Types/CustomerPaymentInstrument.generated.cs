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
/// All possible instruments for CustomerPaymentMethods.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<CustomerPaymentInstrument>))]
public record CustomerPaymentInstrument : GraphQLObject<CustomerPaymentInstrument>, IGraphQLUnionType
{
    public BankAccount? AsBankAccount() => this is CustomerPaymentInstrumentBankAccount wrapper ? wrapper.Value : null;
    public CustomerCreditCard? AsCustomerCreditCard() => this is CustomerPaymentInstrumentCustomerCreditCard wrapper ? wrapper.Value : null;
    public CustomerPaypalBillingAgreement? AsCustomerPaypalBillingAgreement() => this is CustomerPaymentInstrumentCustomerPaypalBillingAgreement wrapper ? wrapper.Value : null;
    public CustomerShopPayAgreement? AsCustomerShopPayAgreement() => this is CustomerPaymentInstrumentCustomerShopPayAgreement wrapper ? wrapper.Value : null;
}