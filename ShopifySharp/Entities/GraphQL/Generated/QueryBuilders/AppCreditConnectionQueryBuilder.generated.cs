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

public class AppCreditConnectionQueryBuilder() : GraphQueryBuilder<AppCreditConnection>("appCreditConnection")
{
    public AppCreditConnectionQueryBuilder AddFieldEdges(Func<AppCreditEdgeQueryBuilder, AppCreditEdgeQueryBuilder> build)
    {
        AddField<AppCreditEdge, AppCreditEdgeQueryBuilder>("edges", build);
        return this;
    }

    public AppCreditConnectionQueryBuilder AddFieldNodes(Func<AppCreditQueryBuilder, AppCreditQueryBuilder> build)
    {
        AddField<AppCredit, AppCreditQueryBuilder>("nodes", build);
        return this;
    }

    public AppCreditConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}