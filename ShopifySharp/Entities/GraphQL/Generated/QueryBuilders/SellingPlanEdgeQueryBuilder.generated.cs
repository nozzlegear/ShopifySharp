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

public class SellingPlanEdgeQueryBuilder() : GraphQueryBuilder<SellingPlanEdge>("sellingPlanEdge")
{
    public SellingPlanEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public SellingPlanEdgeQueryBuilder AddFieldNode(Func<SellingPlanQueryBuilder, SellingPlanQueryBuilder> build)
    {
        AddField<SellingPlan, SellingPlanQueryBuilder>("node", build);
        return this;
    }
}