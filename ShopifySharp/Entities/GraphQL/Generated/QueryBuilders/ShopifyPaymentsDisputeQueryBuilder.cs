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

public class ShopifyPaymentsDisputeQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsDispute>("query shopifyPaymentsDispute")
{
    public ShopifyPaymentsDisputeQueryBuilder AddFieldAmount()
    {
        AddField("amount");
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

    public ShopifyPaymentsDisputeQueryBuilder AddFieldOrder()
    {
        AddField("order");
        return this;
    }

    public ShopifyPaymentsDisputeQueryBuilder AddFieldReasonDetails()
    {
        AddField("reasonDetails");
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