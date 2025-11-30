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

public class CashTrackingAdjustmentEdgeQueryBuilder() : GraphQueryBuilder<CashTrackingAdjustmentEdge>("cashTrackingAdjustmentEdge")
{
    public CashTrackingAdjustmentEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CashTrackingAdjustmentEdgeQueryBuilder AddFieldNode(Func<CashTrackingAdjustmentQueryBuilder, CashTrackingAdjustmentQueryBuilder> build)
    {
        AddField<CashTrackingAdjustment, CashTrackingAdjustmentQueryBuilder>("node", build);
        return this;
    }
}