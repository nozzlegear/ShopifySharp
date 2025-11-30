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

public class StoreCreditAccountExpirationTransactionQueryBuilder() : GraphQueryBuilder<StoreCreditAccountExpirationTransaction>("storeCreditAccountExpirationTransaction")
{
    public StoreCreditAccountExpirationTransactionQueryBuilder AddFieldAccount(Func<StoreCreditAccountQueryBuilder, StoreCreditAccountQueryBuilder> build)
    {
        AddField<StoreCreditAccount, StoreCreditAccountQueryBuilder>("account", build);
        return this;
    }

    public StoreCreditAccountExpirationTransactionQueryBuilder AddFieldAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("amount", build);
        return this;
    }

    public StoreCreditAccountExpirationTransactionQueryBuilder AddFieldBalanceAfterTransaction(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("balanceAfterTransaction", build);
        return this;
    }

    public StoreCreditAccountExpirationTransactionQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public StoreCreditAccountExpirationTransactionQueryBuilder AddFieldCreditTransaction(Func<StoreCreditAccountCreditTransactionQueryBuilder, StoreCreditAccountCreditTransactionQueryBuilder> build)
    {
        AddField<StoreCreditAccountCreditTransaction, StoreCreditAccountCreditTransactionQueryBuilder>("creditTransaction", build);
        return this;
    }

    public StoreCreditAccountExpirationTransactionQueryBuilder AddFieldEvent()
    {
        AddField("event");
        return this;
    }

    public StoreCreditAccountExpirationTransactionQueryBuilder AddUnionCaseOrigin(Func<OrderTransactionQueryBuilder, OrderTransactionQueryBuilder> build)
    {
        AddUnion<OrderTransaction, OrderTransactionQueryBuilder>("origin", build);
        return this;
    }
}