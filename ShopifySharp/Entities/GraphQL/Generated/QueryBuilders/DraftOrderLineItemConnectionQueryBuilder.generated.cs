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

public class DraftOrderLineItemConnectionQueryBuilder() : GraphQueryBuilder<DraftOrderLineItemConnection>("draftOrderLineItemConnection")
{
    public DraftOrderLineItemConnectionQueryBuilder AddFieldEdges(Func<DraftOrderLineItemEdgeQueryBuilder, DraftOrderLineItemEdgeQueryBuilder> build)
    {
        AddField<DraftOrderLineItemEdge, DraftOrderLineItemEdgeQueryBuilder>("edges", build);
        return this;
    }

    public DraftOrderLineItemConnectionQueryBuilder AddFieldNodes(Func<DraftOrderLineItemQueryBuilder, DraftOrderLineItemQueryBuilder> build)
    {
        AddField<DraftOrderLineItem, DraftOrderLineItemQueryBuilder>("nodes", build);
        return this;
    }

    public DraftOrderLineItemConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}