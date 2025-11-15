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

public class CustomerPaymentMethodCreditCardCreatePayloadQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodCreditCardCreatePayload>("query customerPaymentMethodCreditCardCreatePayload")
{
    public CustomerPaymentMethodCreditCardCreatePayloadQueryBuilder AddFieldCustomerPaymentMethod()
    {
        AddField("customerPaymentMethod");
        return this;
    }

    public CustomerPaymentMethodCreditCardCreatePayloadQueryBuilder AddFieldProcessing()
    {
        AddField("processing");
        return this;
    }

    public CustomerPaymentMethodCreditCardCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}