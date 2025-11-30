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

public class PaymentMandateQueryBuilder() : GraphQueryBuilder<PaymentMandate>("query paymentMandate")
{
    public PaymentMandateQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public PaymentMandateQueryBuilder AddFieldPaymentInstrument()
    {
        AddField("paymentInstrument");
        return this;
    }
}