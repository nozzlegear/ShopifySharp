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

public class AppPurchaseOneTimeQueryBuilder() : GraphQueryBuilder<AppPurchaseOneTime>("appPurchaseOneTime")
{
    public AppPurchaseOneTimeQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public AppPurchaseOneTimeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AppPurchaseOneTimeQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public AppPurchaseOneTimeQueryBuilder AddFieldPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("price", build);
        return this;
    }

    public AppPurchaseOneTimeQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public AppPurchaseOneTimeQueryBuilder AddFieldTest()
    {
        AddField("test");
        return this;
    }
}