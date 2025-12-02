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

public class StoreCreditAccountTransactionConnectionQueryBuilder() : GraphQueryBuilder<StoreCreditAccountTransactionConnection>("storeCreditAccountTransactionConnection")
{
    public StoreCreditAccountTransactionConnectionQueryBuilder AddFieldEdges(Func<StoreCreditAccountTransactionEdgeQueryBuilder, StoreCreditAccountTransactionEdgeQueryBuilder> build)
    {
        AddField<StoreCreditAccountTransactionEdge, StoreCreditAccountTransactionEdgeQueryBuilder>("edges", build);
        return this;
    }

    public StoreCreditAccountTransactionConnectionQueryBuilder AddFieldNodes(Func<StoreCreditAccountTransactionQueryBuilder, StoreCreditAccountTransactionQueryBuilder> build)
    {
        AddField<IStoreCreditAccountTransaction, StoreCreditAccountTransactionQueryBuilder>("nodes", build);
        return this;
    }

    public StoreCreditAccountTransactionConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}