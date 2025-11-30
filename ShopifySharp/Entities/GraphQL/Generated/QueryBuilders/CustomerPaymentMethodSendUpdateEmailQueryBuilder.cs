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

public class CustomerPaymentMethodSendUpdateEmailQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodSendUpdateEmailPayload>("query customerPaymentMethodSendUpdateEmail")
{
    public CustomerPaymentMethodSendUpdateEmailQueryBuilder AddArgumentCustomerPaymentMethodId(string? customerPaymentMethodId)
    {
        AddArgument("customerPaymentMethodId", customerPaymentMethodId);
        return this;
    }

    public CustomerPaymentMethodSendUpdateEmailQueryBuilder AddArgumentEmail(EmailInput? email)
    {
        AddArgument("email", email);
        return this;
    }
}