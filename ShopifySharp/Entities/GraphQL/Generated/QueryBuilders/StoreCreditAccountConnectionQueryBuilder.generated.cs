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

public class StoreCreditAccountConnectionQueryBuilder() : GraphQueryBuilder<StoreCreditAccountConnection>("storeCreditAccountConnection")
{
    public StoreCreditAccountConnectionQueryBuilder AddFieldEdges(Func<StoreCreditAccountEdgeQueryBuilder, StoreCreditAccountEdgeQueryBuilder> build)
    {
        AddField<StoreCreditAccountEdge, StoreCreditAccountEdgeQueryBuilder>("edges", build);
        return this;
    }

    public StoreCreditAccountConnectionQueryBuilder AddFieldNodes(Func<StoreCreditAccountQueryBuilder, StoreCreditAccountQueryBuilder> build)
    {
        AddField<StoreCreditAccount, StoreCreditAccountQueryBuilder>("nodes", build);
        return this;
    }

    public StoreCreditAccountConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}