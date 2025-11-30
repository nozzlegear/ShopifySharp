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

public class CustomerPaymentMethodCreditCardUpdateQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodCreditCardUpdatePayload>("query customerPaymentMethodCreditCardUpdate")
{
    public CustomerPaymentMethodCreditCardUpdateQueryBuilder AddArgumentBillingAddress(MailingAddressInput? billingAddress)
    {
        AddArgument("billingAddress", billingAddress);
        return this;
    }

    public CustomerPaymentMethodCreditCardUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public CustomerPaymentMethodCreditCardUpdateQueryBuilder AddArgumentSessionId(string? sessionId)
    {
        AddArgument("sessionId", sessionId);
        return this;
    }
}