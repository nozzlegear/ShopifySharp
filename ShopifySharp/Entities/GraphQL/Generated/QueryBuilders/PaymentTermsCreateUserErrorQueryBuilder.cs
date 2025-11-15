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

public class PaymentTermsCreateUserErrorQueryBuilder() : GraphQueryBuilder<PaymentTermsCreateUserError>("query paymentTermsCreateUserError")
{
    public PaymentTermsCreateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public PaymentTermsCreateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public PaymentTermsCreateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}