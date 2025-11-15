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

public class PaymentTermsCreatePayloadQueryBuilder() : GraphQueryBuilder<PaymentTermsCreatePayload>("query paymentTermsCreatePayload")
{
    public PaymentTermsCreatePayloadQueryBuilder AddFieldPaymentTerms()
    {
        AddField("paymentTerms");
        return this;
    }

    public PaymentTermsCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}