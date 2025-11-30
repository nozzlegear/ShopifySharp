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

public class AppPurchaseQueryBuilder() : GraphQueryBuilder<IAppPurchase>("appPurchase")
{
    public AppPurchaseQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public AppPurchaseQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public AppPurchaseQueryBuilder AddFieldPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("price", build);
        return this;
    }

    public AppPurchaseQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public AppPurchaseQueryBuilder AddFieldTest()
    {
        AddField("test");
        return this;
    }
}