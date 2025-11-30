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

public class OrderDisputeSummaryQueryBuilder() : GraphQueryBuilder<OrderDisputeSummary>("query orderDisputeSummary")
{
    public OrderDisputeSummaryQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public OrderDisputeSummaryQueryBuilder AddFieldInitiatedAs()
    {
        AddField("initiatedAs");
        return this;
    }

    public OrderDisputeSummaryQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }
}