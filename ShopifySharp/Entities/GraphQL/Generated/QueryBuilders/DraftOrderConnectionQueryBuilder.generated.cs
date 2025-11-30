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

public class DraftOrderConnectionQueryBuilder() : GraphQueryBuilder<DraftOrderConnection>("draftOrderConnection")
{
    public DraftOrderConnectionQueryBuilder AddFieldEdges(Func<DraftOrderEdgeQueryBuilder, DraftOrderEdgeQueryBuilder> build)
    {
        AddField<DraftOrderEdge, DraftOrderEdgeQueryBuilder>("edges", build);
        return this;
    }

    public DraftOrderConnectionQueryBuilder AddFieldNodes(Func<DraftOrderQueryBuilder, DraftOrderQueryBuilder> build)
    {
        AddField<DraftOrder, DraftOrderQueryBuilder>("nodes", build);
        return this;
    }

    public DraftOrderConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}