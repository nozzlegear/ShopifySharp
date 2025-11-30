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

public class GiftCardTransactionEdgeQueryBuilder() : GraphQueryBuilder<GiftCardTransactionEdge>("giftCardTransactionEdge")
{
    public GiftCardTransactionEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public GiftCardTransactionEdgeQueryBuilder AddFieldNode(Func<GiftCardTransactionQueryBuilder, GiftCardTransactionQueryBuilder> build)
    {
        AddField<IGiftCardTransaction, GiftCardTransactionQueryBuilder>("node", build);
        return this;
    }
}