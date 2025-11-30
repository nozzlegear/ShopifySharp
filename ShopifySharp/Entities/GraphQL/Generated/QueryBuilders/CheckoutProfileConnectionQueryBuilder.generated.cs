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

public class CheckoutProfileConnectionQueryBuilder() : GraphQueryBuilder<CheckoutProfileConnection>("checkoutProfileConnection")
{
    public CheckoutProfileConnectionQueryBuilder AddFieldEdges(Func<CheckoutProfileEdgeQueryBuilder, CheckoutProfileEdgeQueryBuilder> build)
    {
        AddField<CheckoutProfileEdge, CheckoutProfileEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CheckoutProfileConnectionQueryBuilder AddFieldNodes(Func<CheckoutProfileQueryBuilder, CheckoutProfileQueryBuilder> build)
    {
        AddField<CheckoutProfile, CheckoutProfileQueryBuilder>("nodes", build);
        return this;
    }

    public CheckoutProfileConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}