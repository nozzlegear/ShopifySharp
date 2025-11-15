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

public class MoneyBagQueryBuilder() : GraphQueryBuilder<MoneyBag>("query moneyBag")
{
    public MoneyBagQueryBuilder AddFieldPresentmentMoney()
    {
        AddField("presentmentMoney");
        return this;
    }

    public MoneyBagQueryBuilder AddFieldShopMoney()
    {
        AddField("shopMoney");
        return this;
    }
}