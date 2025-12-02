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

public class TenderTransactionConnectionQueryBuilder() : GraphQueryBuilder<TenderTransactionConnection>("tenderTransactionConnection")
{
    public TenderTransactionConnectionQueryBuilder AddFieldEdges(Func<TenderTransactionEdgeQueryBuilder, TenderTransactionEdgeQueryBuilder> build)
    {
        AddField<TenderTransactionEdge, TenderTransactionEdgeQueryBuilder>("edges", build);
        return this;
    }

    public TenderTransactionConnectionQueryBuilder AddFieldNodes(Func<TenderTransactionQueryBuilder, TenderTransactionQueryBuilder> build)
    {
        AddField<TenderTransaction, TenderTransactionQueryBuilder>("nodes", build);
        return this;
    }

    public TenderTransactionConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}