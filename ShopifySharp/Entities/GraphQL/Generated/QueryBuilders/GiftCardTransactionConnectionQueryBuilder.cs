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

public class GiftCardTransactionConnectionQueryBuilder() : GraphQueryBuilder<GiftCardTransactionConnection>("query giftCardTransactionConnection")
{
    public GiftCardTransactionConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public GiftCardTransactionConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public GiftCardTransactionConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}