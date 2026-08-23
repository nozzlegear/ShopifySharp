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

        public StoreCreditAccountTransactionQueryBuilder OnStoreCreditAccountCreditTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountCreditTransactionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountCreditTransaction>("... on StoreCreditAccountCreditTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountCreditTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public StoreCreditAccountTransactionQueryBuilder OnStoreCreditAccountDebitRevertTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountDebitRevertTransactionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountDebitRevertTransaction>("... on StoreCreditAccountDebitRevertTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountDebitRevertTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public StoreCreditAccountTransactionQueryBuilder OnStoreCreditAccountDebitTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountDebitTransactionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountDebitTransaction>("... on StoreCreditAccountDebitTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountDebitTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public StoreCreditAccountTransactionQueryBuilder OnStoreCreditAccountExpirationTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountExpirationTransactionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountExpirationTransaction>("... on StoreCreditAccountExpirationTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountExpirationTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
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

        public StoreCreditAccountTransactionQueryBuilder StoreCreditAccountTransaction(Action<StoreCreditAccountTransactionInterfaceCasesBuilder> build)
        {
            var query = new Query<IStoreCreditAccountTransaction>("storeCreditAccountTransaction");
            var unionBuilder = new StoreCreditAccountTransactionInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}