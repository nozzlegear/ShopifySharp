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

public class GiftCardConnectionQueryBuilder() : GraphQueryBuilder<GiftCardConnection>("giftCardConnection")
{
    public GiftCardConnectionQueryBuilder AddFieldEdges(Func<GiftCardEdgeQueryBuilder, GiftCardEdgeQueryBuilder> build)
    {
        AddField<GiftCardEdge, GiftCardEdgeQueryBuilder>("edges", build);
        return this;
    }

    public GiftCardConnectionQueryBuilder AddFieldNodes(Func<GiftCardQueryBuilder, GiftCardQueryBuilder> build)
    {
        AddField<GiftCard, GiftCardQueryBuilder>("nodes", build);
        return this;
    }

    public GiftCardConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}