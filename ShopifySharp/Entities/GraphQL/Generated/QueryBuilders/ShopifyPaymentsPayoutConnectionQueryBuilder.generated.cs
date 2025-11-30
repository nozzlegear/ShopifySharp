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

public class ShopifyPaymentsPayoutConnectionQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsPayoutConnection>("shopifyPaymentsPayoutConnection")
{
    public ShopifyPaymentsPayoutConnectionQueryBuilder AddFieldEdges(Func<ShopifyPaymentsPayoutEdgeQueryBuilder, ShopifyPaymentsPayoutEdgeQueryBuilder> build)
    {
        AddField<ShopifyPaymentsPayoutEdge, ShopifyPaymentsPayoutEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ShopifyPaymentsPayoutConnectionQueryBuilder AddFieldNodes(Func<ShopifyPaymentsPayoutQueryBuilder, ShopifyPaymentsPayoutQueryBuilder> build)
    {
        AddField<ShopifyPaymentsPayout, ShopifyPaymentsPayoutQueryBuilder>("nodes", build);
        return this;
    }

    public ShopifyPaymentsPayoutConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}