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

public class SellingPlanConnectionQueryBuilder() : GraphQueryBuilder<SellingPlanConnection>("sellingPlanConnection")
{
    public SellingPlanConnectionQueryBuilder AddFieldEdges(Func<SellingPlanEdgeQueryBuilder, SellingPlanEdgeQueryBuilder> build)
    {
        AddField<SellingPlanEdge, SellingPlanEdgeQueryBuilder>("edges", build);
        return this;
    }

    public SellingPlanConnectionQueryBuilder AddFieldNodes(Func<SellingPlanQueryBuilder, SellingPlanQueryBuilder> build)
    {
        AddField<SellingPlan, SellingPlanQueryBuilder>("nodes", build);
        return this;
    }

    public SellingPlanConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}