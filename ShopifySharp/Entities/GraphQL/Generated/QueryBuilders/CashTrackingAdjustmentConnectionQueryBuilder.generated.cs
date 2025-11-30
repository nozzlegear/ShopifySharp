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

public class CashTrackingAdjustmentConnectionQueryBuilder() : GraphQueryBuilder<CashTrackingAdjustmentConnection>("cashTrackingAdjustmentConnection")
{
    public CashTrackingAdjustmentConnectionQueryBuilder AddFieldEdges(Func<CashTrackingAdjustmentEdgeQueryBuilder, CashTrackingAdjustmentEdgeQueryBuilder> build)
    {
        AddField<CashTrackingAdjustmentEdge, CashTrackingAdjustmentEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CashTrackingAdjustmentConnectionQueryBuilder AddFieldNodes(Func<CashTrackingAdjustmentQueryBuilder, CashTrackingAdjustmentQueryBuilder> build)
    {
        AddField<CashTrackingAdjustment, CashTrackingAdjustmentQueryBuilder>("nodes", build);
        return this;
    }

    public CashTrackingAdjustmentConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}