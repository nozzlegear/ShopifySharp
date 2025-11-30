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

public class CashTrackingSessionConnectionQueryBuilder() : GraphQueryBuilder<CashTrackingSessionConnection>("query cashTrackingSessionConnection")
{
    public CashTrackingSessionConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CashTrackingSessionConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public CashTrackingSessionConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}