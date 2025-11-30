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

public class MoneyBagQueryBuilder() : GraphQueryBuilder<MoneyBag>("moneyBag")
{
    public MoneyBagQueryBuilder AddFieldPresentmentMoney(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("presentmentMoney", build);
        return this;
    }

    public MoneyBagQueryBuilder AddFieldShopMoney(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("shopMoney", build);
        return this;
    }
}