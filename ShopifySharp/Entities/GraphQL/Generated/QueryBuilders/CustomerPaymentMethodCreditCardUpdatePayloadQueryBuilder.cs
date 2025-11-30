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

public class CustomerPaymentMethodCreditCardUpdatePayloadQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodCreditCardUpdatePayload>("query customerPaymentMethodCreditCardUpdatePayload")
{
    public CustomerPaymentMethodCreditCardUpdatePayloadQueryBuilder AddFieldCustomerPaymentMethod()
    {
        AddField("customerPaymentMethod");
        return this;
    }

    public CustomerPaymentMethodCreditCardUpdatePayloadQueryBuilder AddFieldProcessing()
    {
        AddField("processing");
        return this;
    }

    public CustomerPaymentMethodCreditCardUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}