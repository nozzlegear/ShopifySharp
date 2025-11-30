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

public class CustomerPaymentMethodCreateFromDuplicationDataUserErrorQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodCreateFromDuplicationDataUserError>("query customerPaymentMethodCreateFromDuplicationDataUserError")
{
    public CustomerPaymentMethodCreateFromDuplicationDataUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public CustomerPaymentMethodCreateFromDuplicationDataUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public CustomerPaymentMethodCreateFromDuplicationDataUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}