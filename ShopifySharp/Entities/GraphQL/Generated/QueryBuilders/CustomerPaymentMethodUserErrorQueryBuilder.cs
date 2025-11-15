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

public class CustomerPaymentMethodUserErrorQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodUserError>("query customerPaymentMethodUserError")
{
    public CustomerPaymentMethodUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public CustomerPaymentMethodUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public CustomerPaymentMethodUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}