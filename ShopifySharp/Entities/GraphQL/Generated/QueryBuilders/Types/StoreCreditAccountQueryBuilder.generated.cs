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
    public sealed class StoreCreditAccountQueryBuilder : FieldsQueryBuilderBase<StoreCreditAccount, StoreCreditAccountQueryBuilder>
    {
        protected override StoreCreditAccountQueryBuilder Self => this;

        public StoreCreditAccountQueryBuilder() : this("storeCreditAccount")
        {
        }

        public StoreCreditAccountQueryBuilder(string name) : base(new Query<StoreCreditAccount>(name))
        {
        }

        public StoreCreditAccountQueryBuilder(IQuery<StoreCreditAccount> query) : base(query)
        {
        }

        public StoreCreditAccountQueryBuilder Balance(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("balance");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public StoreCreditAccountQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public StoreCreditAccountQueryBuilder Owner(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.HasStoreCreditAccountsQueryBuilder> build)
        {
            var query = new Query<IHasStoreCreditAccounts>("owner");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.HasStoreCreditAccountsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IHasStoreCreditAccounts>(query);
            return this;
        }

        public StoreCreditAccountQueryBuilder Transactions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountTransactionConnectionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountTransactionConnection>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountTransactionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountTransactionConnection>(query);
            return this;
        }
    }
}