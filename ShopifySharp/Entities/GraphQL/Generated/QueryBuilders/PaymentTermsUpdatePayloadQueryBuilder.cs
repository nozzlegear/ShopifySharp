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

public class PaymentTermsUpdatePayloadQueryBuilder() : GraphQueryBuilder<PaymentTermsUpdatePayload>("query paymentTermsUpdatePayload")
{
    public PaymentTermsUpdatePayloadQueryBuilder AddFieldPaymentTerms()
    {
        AddField("paymentTerms");
        return this;
    }

    public PaymentTermsUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}