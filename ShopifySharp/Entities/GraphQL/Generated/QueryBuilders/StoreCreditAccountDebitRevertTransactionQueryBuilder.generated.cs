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

public class StoreCreditAccountDebitRevertTransactionQueryBuilder() : GraphQueryBuilder<StoreCreditAccountDebitRevertTransaction>("storeCreditAccountDebitRevertTransaction")
{
    public StoreCreditAccountDebitRevertTransactionQueryBuilder AddFieldAccount(Func<StoreCreditAccountQueryBuilder, StoreCreditAccountQueryBuilder> build)
    {
        AddField<StoreCreditAccount, StoreCreditAccountQueryBuilder>("account", build);
        return this;
    }

    public StoreCreditAccountDebitRevertTransactionQueryBuilder AddFieldAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("amount", build);
        return this;
    }

    public StoreCreditAccountDebitRevertTransactionQueryBuilder AddFieldBalanceAfterTransaction(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("balanceAfterTransaction", build);
        return this;
    }

    public StoreCreditAccountDebitRevertTransactionQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public StoreCreditAccountDebitRevertTransactionQueryBuilder AddFieldDebitTransaction(Func<StoreCreditAccountDebitTransactionQueryBuilder, StoreCreditAccountDebitTransactionQueryBuilder> build)
    {
        AddField<StoreCreditAccountDebitTransaction, StoreCreditAccountDebitTransactionQueryBuilder>("debitTransaction", build);
        return this;
    }

    public StoreCreditAccountDebitRevertTransactionQueryBuilder AddFieldEvent()
    {
        AddField("event");
        return this;
    }

    public StoreCreditAccountDebitRevertTransactionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public StoreCreditAccountDebitRevertTransactionQueryBuilder AddUnionCaseOrigin(Func<OrderTransactionQueryBuilder, OrderTransactionQueryBuilder> build)
    {
        AddUnion<OrderTransaction, OrderTransactionQueryBuilder>("origin", build);
        return this;
    }
}