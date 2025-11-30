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

public class AppCreditQueryBuilder() : GraphQueryBuilder<AppCredit>("appCredit")
{
    public AppCreditQueryBuilder AddFieldAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("amount", build);
        return this;
    }

    public AppCreditQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public AppCreditQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public AppCreditQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AppCreditQueryBuilder AddFieldTest()
    {
        AddField("test");
        return this;
    }
}