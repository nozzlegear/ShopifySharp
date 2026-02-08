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
    public sealed class StoreCreditAccountExpirationTransactionQueryBuilder : FieldsQueryBuilderBase<StoreCreditAccountExpirationTransaction, StoreCreditAccountExpirationTransactionQueryBuilder>
    {
        protected override StoreCreditAccountExpirationTransactionQueryBuilder Self => this;

        public StoreCreditAccountExpirationTransactionQueryBuilder() : this("storeCreditAccountExpirationTransaction")
        {
        }

        public StoreCreditAccountExpirationTransactionQueryBuilder(string name) : base(new Query<StoreCreditAccountExpirationTransaction>(name))
        {
        }

        public StoreCreditAccountExpirationTransactionQueryBuilder(IQuery<StoreCreditAccountExpirationTransaction> query) : base(query)
        {
        }

        public StoreCreditAccountExpirationTransactionQueryBuilder Account(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccount>("account");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccount>(query);
            return this;
        }

        public StoreCreditAccountExpirationTransactionQueryBuilder Amount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public StoreCreditAccountExpirationTransactionQueryBuilder BalanceAfterTransaction(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("balanceAfterTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public StoreCreditAccountExpirationTransactionQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public StoreCreditAccountExpirationTransactionQueryBuilder CreditTransaction(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountCreditTransactionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountCreditTransaction>("creditTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountCreditTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountCreditTransaction>(query);
            return this;
        }

        public StoreCreditAccountExpirationTransactionQueryBuilder Event()
        {
            base.InnerQuery.AddField("event");
            return this;
        }

        public StoreCreditAccountExpirationTransactionQueryBuilder Origin(Action<StoreCreditAccountTransactionOriginUnionCasesBuilder> build)
        {
            var query = new Query<StoreCreditAccountTransactionOrigin>("origin");
            var unionBuilder = new StoreCreditAccountTransactionOriginUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}