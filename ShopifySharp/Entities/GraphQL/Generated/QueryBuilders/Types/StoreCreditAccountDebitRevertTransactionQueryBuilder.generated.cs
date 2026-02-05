#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class StoreCreditAccountDebitRevertTransactionQueryBuilder : FieldsQueryBuilderBase<StoreCreditAccountDebitRevertTransaction, StoreCreditAccountDebitRevertTransactionQueryBuilder>
    {
        protected override StoreCreditAccountDebitRevertTransactionQueryBuilder Self => this;

        public StoreCreditAccountDebitRevertTransactionQueryBuilder() : this("storeCreditAccountDebitRevertTransaction")
        {
        }

        public StoreCreditAccountDebitRevertTransactionQueryBuilder(string name) : base(new Query<StoreCreditAccountDebitRevertTransaction>(name))
        {
        }

        public StoreCreditAccountDebitRevertTransactionQueryBuilder(IQuery<StoreCreditAccountDebitRevertTransaction> query) : base(query)
        {
        }

        public StoreCreditAccountDebitRevertTransactionQueryBuilder Account(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccount>("account");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccount>(query);
            return this;
        }

        public StoreCreditAccountDebitRevertTransactionQueryBuilder Amount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public StoreCreditAccountDebitRevertTransactionQueryBuilder BalanceAfterTransaction(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("balanceAfterTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public StoreCreditAccountDebitRevertTransactionQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public StoreCreditAccountDebitRevertTransactionQueryBuilder DebitTransaction(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountDebitTransactionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountDebitTransaction>("debitTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountDebitTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountDebitTransaction>(query);
            return this;
        }

        public StoreCreditAccountDebitRevertTransactionQueryBuilder Event()
        {
            base.InnerQuery.AddField("event");
            return this;
        }

        public StoreCreditAccountDebitRevertTransactionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public StoreCreditAccountDebitRevertTransactionQueryBuilder Origin(Action<StoreCreditAccountTransactionOriginUnionCasesBuilder> build)
        {
            var query = new Query<StoreCreditAccountTransactionOrigin>("origin");
            var unionBuilder = new StoreCreditAccountTransactionOriginUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}