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

public class PaymentTermsDeleteUserErrorQueryBuilder() : GraphQueryBuilder<PaymentTermsDeleteUserError>("query paymentTermsDeleteUserError")
{
    public PaymentTermsDeleteUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public PaymentTermsDeleteUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public PaymentTermsDeleteUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}