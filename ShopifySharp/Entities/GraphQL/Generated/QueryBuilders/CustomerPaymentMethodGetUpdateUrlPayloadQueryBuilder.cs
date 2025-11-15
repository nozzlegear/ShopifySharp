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

public class CustomerPaymentMethodGetUpdateUrlPayloadQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodGetUpdateUrlPayload>("query customerPaymentMethodGetUpdateUrlPayload")
{
    public CustomerPaymentMethodGetUpdateUrlPayloadQueryBuilder AddFieldUpdatePaymentMethodUrl()
    {
        AddField("updatePaymentMethodUrl");
        return this;
    }

    public CustomerPaymentMethodGetUpdateUrlPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}