#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class CustomerPaymentMethodCreditCardCreateQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodCreditCardCreatePayload>("query customerPaymentMethodCreditCardCreate")
{
    public CustomerPaymentMethodCreditCardCreateQueryBuilder AddArgumentBillingAddress(MailingAddressInput? billingAddress)
    {
        AddArgument("billingAddress", billingAddress);
        return this;
    }

    public CustomerPaymentMethodCreditCardCreateQueryBuilder AddArgumentCustomerId(string? customerId)
    {
        AddArgument("customerId", customerId);
        return this;
    }

    public CustomerPaymentMethodCreditCardCreateQueryBuilder AddArgumentSessionId(string? sessionId)
    {
        AddArgument("sessionId", sessionId);
        return this;
    }
}