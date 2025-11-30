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

public class AbandonedCheckoutLineItemConnectionQueryBuilder() : GraphQueryBuilder<AbandonedCheckoutLineItemConnection>("abandonedCheckoutLineItemConnection")
{
    public AbandonedCheckoutLineItemConnectionQueryBuilder AddFieldEdges(Func<AbandonedCheckoutLineItemEdgeQueryBuilder, AbandonedCheckoutLineItemEdgeQueryBuilder> build)
    {
        AddField<AbandonedCheckoutLineItemEdge, AbandonedCheckoutLineItemEdgeQueryBuilder>("edges", build);
        return this;
    }

    public AbandonedCheckoutLineItemConnectionQueryBuilder AddFieldNodes(Func<AbandonedCheckoutLineItemQueryBuilder, AbandonedCheckoutLineItemQueryBuilder> build)
    {
        AddField<AbandonedCheckoutLineItem, AbandonedCheckoutLineItemQueryBuilder>("nodes", build);
        return this;
    }

    public AbandonedCheckoutLineItemConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}