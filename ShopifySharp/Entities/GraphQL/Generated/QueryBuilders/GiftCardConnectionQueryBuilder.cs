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

public class GiftCardConnectionQueryBuilder() : GraphQueryBuilder<GiftCardConnection>("query giftCardConnection")
{
    public GiftCardConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public GiftCardConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public GiftCardConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}