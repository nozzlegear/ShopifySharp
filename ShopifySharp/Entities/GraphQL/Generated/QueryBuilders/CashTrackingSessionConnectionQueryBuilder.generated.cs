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

public class CashTrackingSessionConnectionQueryBuilder() : GraphQueryBuilder<CashTrackingSessionConnection>("cashTrackingSessionConnection")
{
    public CashTrackingSessionConnectionQueryBuilder AddFieldEdges(Func<CashTrackingSessionEdgeQueryBuilder, CashTrackingSessionEdgeQueryBuilder> build)
    {
        AddField<CashTrackingSessionEdge, CashTrackingSessionEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CashTrackingSessionConnectionQueryBuilder AddFieldNodes(Func<CashTrackingSessionQueryBuilder, CashTrackingSessionQueryBuilder> build)
    {
        AddField<CashTrackingSession, CashTrackingSessionQueryBuilder>("nodes", build);
        return this;
    }

    public CashTrackingSessionConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}