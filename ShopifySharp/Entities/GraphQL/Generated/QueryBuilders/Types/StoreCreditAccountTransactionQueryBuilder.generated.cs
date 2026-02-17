#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class StoreCreditAccountTransactionQueryBuilder : FieldsQueryBuilderBase<IStoreCreditAccountTransaction, StoreCreditAccountTransactionQueryBuilder>
    {
        protected override StoreCreditAccountTransactionQueryBuilder Self => this;

        public StoreCreditAccountTransactionQueryBuilder() : this("storeCreditAccountTransaction")
        {
        }

        public StoreCreditAccountTransactionQueryBuilder(string name) : base(new Query<IStoreCreditAccountTransaction>(name))
        {
        }

        public StoreCreditAccountTransactionQueryBuilder(IQuery<IStoreCreditAccountTransaction> query) : base(query)
        {
        }

        public StoreCreditAccountTransactionQueryBuilder Account(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccount>("account");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccount>(query);
            return this;
        }

        public StoreCreditAccountTransactionQueryBuilder Amount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public StoreCreditAccountTransactionQueryBuilder BalanceAfterTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("balanceAfterTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public StoreCreditAccountTransactionQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public StoreCreditAccountTransactionQueryBuilder Event()
        {
            base.InnerQuery.AddField("event");
            return this;
        }

        public StoreCreditAccountTransactionQueryBuilder Origin(Action<StoreCreditAccountTransactionOriginUnionCasesBuilder> build)
        {
            var query = new Query<StoreCreditAccountTransactionOrigin>("origin");
            var unionBuilder = new StoreCreditAccountTransactionOriginUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}