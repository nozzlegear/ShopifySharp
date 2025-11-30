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

public class SaleConnectionQueryBuilder() : GraphQueryBuilder<SaleConnection>("saleConnection")
{
    public SaleConnectionQueryBuilder AddFieldEdges(Func<SaleEdgeQueryBuilder, SaleEdgeQueryBuilder> build)
    {
        AddField<SaleEdge, SaleEdgeQueryBuilder>("edges", build);
        return this;
    }

    public SaleConnectionQueryBuilder AddFieldNodes(Func<SaleQueryBuilder, SaleQueryBuilder> build)
    {
        AddField<ISale, SaleQueryBuilder>("nodes", build);
        return this;
    }

    public SaleConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}