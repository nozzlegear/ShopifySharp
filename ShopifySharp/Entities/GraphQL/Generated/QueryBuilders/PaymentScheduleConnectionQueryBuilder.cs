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

public class PaymentScheduleConnectionQueryBuilder() : GraphQueryBuilder<PaymentScheduleConnection>("query paymentScheduleConnection")
{
    public PaymentScheduleConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public PaymentScheduleConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public PaymentScheduleConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}