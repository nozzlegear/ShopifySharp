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

public class CustomerVisitProductInfoConnectionQueryBuilder() : GraphQueryBuilder<CustomerVisitProductInfoConnection>("customerVisitProductInfoConnection")
{
    public CustomerVisitProductInfoConnectionQueryBuilder AddFieldEdges(Func<CustomerVisitProductInfoEdgeQueryBuilder, CustomerVisitProductInfoEdgeQueryBuilder> build)
    {
        AddField<CustomerVisitProductInfoEdge, CustomerVisitProductInfoEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CustomerVisitProductInfoConnectionQueryBuilder AddFieldNodes(Func<CustomerVisitProductInfoQueryBuilder, CustomerVisitProductInfoQueryBuilder> build)
    {
        AddField<CustomerVisitProductInfo, CustomerVisitProductInfoQueryBuilder>("nodes", build);
        return this;
    }

    public CustomerVisitProductInfoConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}