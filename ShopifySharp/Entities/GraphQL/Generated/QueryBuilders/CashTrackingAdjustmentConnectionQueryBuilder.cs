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

public class CashTrackingAdjustmentConnectionQueryBuilder() : GraphQueryBuilder<CashTrackingAdjustmentConnection>("query cashTrackingAdjustmentConnection")
{
    public CashTrackingAdjustmentConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CashTrackingAdjustmentConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public CashTrackingAdjustmentConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}