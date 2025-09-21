#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// All possible instruments for CustomerPaymentMethods.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<CustomerPaymentInstrument>))]
public record CustomerPaymentInstrument : GraphQLObject<CustomerPaymentInstrument>, IGraphQLUnionType
{
    public CustomerCreditCard? AsCustomerCreditCard() => this is CustomerPaymentInstrumentCustomerCreditCard wrapper ? wrapper.Value : null;
    public CustomerPaypalBillingAgreement? AsCustomerPaypalBillingAgreement() => this is CustomerPaymentInstrumentCustomerPaypalBillingAgreement wrapper ? wrapper.Value : null;
    public CustomerShopPayAgreement? AsCustomerShopPayAgreement() => this is CustomerPaymentInstrumentCustomerShopPayAgreement wrapper ? wrapper.Value : null;
}