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

public class StoreCreditAccountTransactionQueryBuilder() : GraphQueryBuilder<IStoreCreditAccountTransaction>("storeCreditAccountTransaction")
{
    public StoreCreditAccountTransactionQueryBuilder AddFieldAccount(Func<StoreCreditAccountQueryBuilder, StoreCreditAccountQueryBuilder> build)
    {
        AddField<StoreCreditAccount, StoreCreditAccountQueryBuilder>("account", build);
        return this;
    }

    public StoreCreditAccountTransactionQueryBuilder AddFieldAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("amount", build);
        return this;
    }

    public StoreCreditAccountTransactionQueryBuilder AddFieldBalanceAfterTransaction(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("balanceAfterTransaction", build);
        return this;
    }

    public StoreCreditAccountTransactionQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public StoreCreditAccountTransactionQueryBuilder AddFieldEvent()
    {
        AddField("event");
        return this;
    }

    public StoreCreditAccountTransactionQueryBuilder AddUnionCaseOrigin(Func<OrderTransactionQueryBuilder, OrderTransactionQueryBuilder> build)
    {
        AddUnion<OrderTransaction, OrderTransactionQueryBuilder>("origin", build);
        return this;
    }
}