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

public class StoreCreditAccountQueryBuilder() : GraphQueryBuilder<StoreCreditAccount>("storeCreditAccount")
{
    public StoreCreditAccountQueryBuilder AddFieldBalance(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("balance", build);
        return this;
    }

    public StoreCreditAccountQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public StoreCreditAccountQueryBuilder AddFieldOwner(Func<HasStoreCreditAccountsQueryBuilder, HasStoreCreditAccountsQueryBuilder> build)
    {
        AddField<IHasStoreCreditAccounts, HasStoreCreditAccountsQueryBuilder>("owner", build);
        return this;
    }

    public StoreCreditAccountQueryBuilder AddFieldTransactions(Func<StoreCreditAccountTransactionConnectionQueryBuilder, StoreCreditAccountTransactionConnectionQueryBuilder> build)
    {
        AddField<StoreCreditAccountTransactionConnection, StoreCreditAccountTransactionConnectionQueryBuilder>("transactions", build);
        return this;
    }
}