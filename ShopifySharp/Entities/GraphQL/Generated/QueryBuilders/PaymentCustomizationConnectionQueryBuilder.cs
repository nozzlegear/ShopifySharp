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

public class PaymentCustomizationConnectionQueryBuilder() : GraphQueryBuilder<PaymentCustomizationConnection>("query paymentCustomizationConnection")
{
    public PaymentCustomizationConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public PaymentCustomizationConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public PaymentCustomizationConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}