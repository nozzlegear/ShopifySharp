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

public class CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodGetDuplicationDataUserError>("query customerPaymentMethodGetDuplicationDataUserError")
{
    public CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public CustomerPaymentMethodGetDuplicationDataUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}