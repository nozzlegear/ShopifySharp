#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ShopifyPaymentsDisputeQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsDispute>("shopifyPaymentsDispute")
{
    public ShopifyPaymentsDisputeQueryBuilder AddFieldAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("amount", build);
        return this;
    }

    public ShopifyPaymentsDisputeQueryBuilder AddFieldEvidenceDueBy()
    {
        AddField("evidenceDueBy");
        return this;
    }

    public ShopifyPaymentsDisputeQueryBuilder AddFieldEvidenceSentOn()
    {
        AddField("evidenceSentOn");
        return this;
    }

    public ShopifyPaymentsDisputeQueryBuilder AddFieldFinalizedOn()
    {
        AddField("finalizedOn");
        return this;
    }

    public ShopifyPaymentsDisputeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ShopifyPaymentsDisputeQueryBuilder AddFieldInitiatedAt()
    {
        AddField("initiatedAt");
        return this;
    }

    public ShopifyPaymentsDisputeQueryBuilder AddFieldLegacyResourceId()
    {
        AddField("legacyResourceId");
        return this;
    }

    public ShopifyPaymentsDisputeQueryBuilder AddFieldOrder(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddField<Order, OrderQueryBuilder>("order", build);
        return this;
    }

    public ShopifyPaymentsDisputeQueryBuilder AddFieldReasonDetails(Func<ShopifyPaymentsDisputeReasonDetailsQueryBuilder, ShopifyPaymentsDisputeReasonDetailsQueryBuilder> build)
    {
        AddField<ShopifyPaymentsDisputeReasonDetails, ShopifyPaymentsDisputeReasonDetailsQueryBuilder>("reasonDetails", build);
        return this;
    }

    public ShopifyPaymentsDisputeQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public ShopifyPaymentsDisputeQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }
}