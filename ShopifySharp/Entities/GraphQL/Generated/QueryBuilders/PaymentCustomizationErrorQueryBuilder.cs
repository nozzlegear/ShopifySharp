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

public class PaymentCustomizationErrorQueryBuilder() : GraphQueryBuilder<PaymentCustomizationError>("query paymentCustomizationError")
{
    public PaymentCustomizationErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public PaymentCustomizationErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public PaymentCustomizationErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}