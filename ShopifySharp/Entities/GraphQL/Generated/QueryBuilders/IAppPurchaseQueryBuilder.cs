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

public class IAppPurchaseQueryBuilder() : GraphQueryBuilder<IAppPurchase>("query iAppPurchase")
{
    public IAppPurchaseQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public IAppPurchaseQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public IAppPurchaseQueryBuilder AddFieldPrice()
    {
        AddField("price");
        return this;
    }

    public IAppPurchaseQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public IAppPurchaseQueryBuilder AddFieldTest()
    {
        AddField("test");
        return this;
    }
}