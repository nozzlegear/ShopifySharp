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

public class CustomerPaymentMethodRevokePayloadQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodRevokePayload>("query customerPaymentMethodRevokePayload")
{
    public CustomerPaymentMethodRevokePayloadQueryBuilder AddFieldRevokedCustomerPaymentMethodId()
    {
        AddField("revokedCustomerPaymentMethodId");
        return this;
    }

    public CustomerPaymentMethodRevokePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}