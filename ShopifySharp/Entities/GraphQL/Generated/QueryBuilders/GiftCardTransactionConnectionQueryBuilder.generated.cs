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

public class GiftCardTransactionConnectionQueryBuilder() : GraphQueryBuilder<GiftCardTransactionConnection>("giftCardTransactionConnection")
{
    public GiftCardTransactionConnectionQueryBuilder AddFieldEdges(Func<GiftCardTransactionEdgeQueryBuilder, GiftCardTransactionEdgeQueryBuilder> build)
    {
        AddField<GiftCardTransactionEdge, GiftCardTransactionEdgeQueryBuilder>("edges", build);
        return this;
    }

    public GiftCardTransactionConnectionQueryBuilder AddFieldNodes(Func<GiftCardTransactionQueryBuilder, GiftCardTransactionQueryBuilder> build)
    {
        AddField<IGiftCardTransaction, GiftCardTransactionQueryBuilder>("nodes", build);
        return this;
    }

    public GiftCardTransactionConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}