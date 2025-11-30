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

public class CustomerPaymentMethodRemoteCreatePayloadQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodRemoteCreatePayload>("query customerPaymentMethodRemoteCreatePayload")
{
    public CustomerPaymentMethodRemoteCreatePayloadQueryBuilder AddFieldCustomerPaymentMethod()
    {
        AddField("customerPaymentMethod");
        return this;
    }

    public CustomerPaymentMethodRemoteCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}