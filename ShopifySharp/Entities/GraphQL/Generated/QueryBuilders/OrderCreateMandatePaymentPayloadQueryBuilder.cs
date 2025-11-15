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

public class OrderCreateMandatePaymentPayloadQueryBuilder() : GraphQueryBuilder<OrderCreateMandatePaymentPayload>("query orderCreateMandatePaymentPayload")
{
    public OrderCreateMandatePaymentPayloadQueryBuilder AddFieldJob()
    {
        AddField("job");
        return this;
    }

    public OrderCreateMandatePaymentPayloadQueryBuilder AddFieldPaymentReferenceId()
    {
        AddField("paymentReferenceId");
        return this;
    }

    public OrderCreateMandatePaymentPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}