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

public class AppDiscountTypeConnectionQueryBuilder() : GraphQueryBuilder<AppDiscountTypeConnection>("appDiscountTypeConnection")
{
    public AppDiscountTypeConnectionQueryBuilder AddFieldEdges(Func<AppDiscountTypeEdgeQueryBuilder, AppDiscountTypeEdgeQueryBuilder> build)
    {
        AddField<AppDiscountTypeEdge, AppDiscountTypeEdgeQueryBuilder>("edges", build);
        return this;
    }

    public AppDiscountTypeConnectionQueryBuilder AddFieldNodes(Func<AppDiscountTypeQueryBuilder, AppDiscountTypeQueryBuilder> build)
    {
        AddField<AppDiscountType, AppDiscountTypeQueryBuilder>("nodes", build);
        return this;
    }

    public AppDiscountTypeConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}