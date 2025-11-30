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

public class ReturnLineItemTypeConnectionQueryBuilder() : GraphQueryBuilder<ReturnLineItemTypeConnection>("returnLineItemTypeConnection")
{
    public ReturnLineItemTypeConnectionQueryBuilder AddFieldEdges(Func<ReturnLineItemTypeEdgeQueryBuilder, ReturnLineItemTypeEdgeQueryBuilder> build)
    {
        AddField<ReturnLineItemTypeEdge, ReturnLineItemTypeEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ReturnLineItemTypeConnectionQueryBuilder AddFieldNodes(Func<ReturnLineItemTypeQueryBuilder, ReturnLineItemTypeQueryBuilder> build)
    {
        AddField<IReturnLineItemType, ReturnLineItemTypeQueryBuilder>("nodes", build);
        return this;
    }

    public ReturnLineItemTypeConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}