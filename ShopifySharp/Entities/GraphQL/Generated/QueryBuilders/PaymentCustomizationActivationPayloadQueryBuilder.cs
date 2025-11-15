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

public class PaymentCustomizationActivationPayloadQueryBuilder() : GraphQueryBuilder<PaymentCustomizationActivationPayload>("query paymentCustomizationActivationPayload")
{
    public PaymentCustomizationActivationPayloadQueryBuilder AddFieldIds()
    {
        AddField("ids");
        return this;
    }

    public PaymentCustomizationActivationPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}