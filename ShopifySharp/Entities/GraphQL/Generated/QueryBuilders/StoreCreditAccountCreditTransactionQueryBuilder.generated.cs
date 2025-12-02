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

public class StoreCreditAccountCreditTransactionQueryBuilder() : GraphQueryBuilder<StoreCreditAccountCreditTransaction>("storeCreditAccountCreditTransaction")
{
    public StoreCreditAccountCreditTransactionQueryBuilder AddFieldAccount(Func<StoreCreditAccountQueryBuilder, StoreCreditAccountQueryBuilder> build)
    {
        AddField<StoreCreditAccount, StoreCreditAccountQueryBuilder>("account", build);
        return this;
    }

    public StoreCreditAccountCreditTransactionQueryBuilder AddFieldAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("amount", build);
        return this;
    }

    public StoreCreditAccountCreditTransactionQueryBuilder AddFieldBalanceAfterTransaction(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("balanceAfterTransaction", build);
        return this;
    }

    public StoreCreditAccountCreditTransactionQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public StoreCreditAccountCreditTransactionQueryBuilder AddFieldEvent()
    {
        AddField("event");
        return this;
    }

    public StoreCreditAccountCreditTransactionQueryBuilder AddFieldExpiresAt()
    {
        AddField("expiresAt");
        return this;
    }

    public StoreCreditAccountCreditTransactionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public StoreCreditAccountCreditTransactionQueryBuilder AddUnionCaseOrigin(Func<OrderTransactionQueryBuilder, OrderTransactionQueryBuilder> build)
    {
        AddUnion<OrderTransaction, OrderTransactionQueryBuilder>("origin", build);
        return this;
    }

    public StoreCreditAccountCreditTransactionQueryBuilder AddFieldRemainingAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("remainingAmount", build);
        return this;
    }
}