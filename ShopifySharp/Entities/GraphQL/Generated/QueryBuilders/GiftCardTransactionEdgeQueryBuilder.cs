#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class GiftCardTransactionEdgeQueryBuilder() : GraphQueryBuilder<GiftCardTransactionEdge>("query giftCardTransactionEdge")
{
    public GiftCardTransactionEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public GiftCardTransactionEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}