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
    public sealed class QueryRootStoreCreditAccountQueryBuilder : FieldsQueryBuilderBase<StoreCreditAccount, QueryRootStoreCreditAccountQueryBuilder>, IHasArguments<QueryRootStoreCreditAccountArgumentsBuilder>
    {
        public QueryRootStoreCreditAccountArgumentsBuilder Arguments { get; }
        protected override QueryRootStoreCreditAccountQueryBuilder Self => this;

        public QueryRootStoreCreditAccountQueryBuilder(string name) : base(new Query<StoreCreditAccount>(name))
        {
            Arguments = new QueryRootStoreCreditAccountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootStoreCreditAccountQueryBuilder(IQuery<StoreCreditAccount> query) : base(query)
        {
            Arguments = new QueryRootStoreCreditAccountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootStoreCreditAccountQueryBuilder SetArguments(Action<QueryRootStoreCreditAccountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootStoreCreditAccountQueryBuilder Balance(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("balance");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootStoreCreditAccountQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootStoreCreditAccountQueryBuilder Owner(Action<ShopifySharp.GraphQL.QueryBuilders.Types.HasStoreCreditAccountsQueryBuilder> build)
        {
            var query = new Query<IHasStoreCreditAccounts>("owner");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.HasStoreCreditAccountsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IHasStoreCreditAccounts>(query);
            return this;
        }

        public QueryRootStoreCreditAccountQueryBuilder Transactions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountTransactionConnectionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountTransactionConnection>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountTransactionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountTransactionConnection>(query);
            return this;
        }
    }
}