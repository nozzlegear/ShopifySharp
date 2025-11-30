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

public class SellingPlanGroupEdgeQueryBuilder() : GraphQueryBuilder<SellingPlanGroupEdge>("sellingPlanGroupEdge")
{
    public SellingPlanGroupEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public SellingPlanGroupEdgeQueryBuilder AddFieldNode(Func<SellingPlanGroupQueryBuilder, SellingPlanGroupQueryBuilder> build)
    {
        AddField<SellingPlanGroup, SellingPlanGroupQueryBuilder>("node", build);
        return this;
    }
}