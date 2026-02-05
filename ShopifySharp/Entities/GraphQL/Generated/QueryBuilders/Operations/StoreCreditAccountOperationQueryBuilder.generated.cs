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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class StoreCreditAccountOperationQueryBuilder : FieldsQueryBuilderBase<StoreCreditAccount, StoreCreditAccountOperationQueryBuilder>, IGraphOperationQueryBuilder<StoreCreditAccount>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public StoreCreditAccountArgumentsBuilder Arguments { get; }
        protected override StoreCreditAccountOperationQueryBuilder Self => this;

        public StoreCreditAccountOperationQueryBuilder() : this("storeCreditAccount")
        {
        }

        public StoreCreditAccountOperationQueryBuilder(string name) : base(new Query<StoreCreditAccount>(name))
        {
            Arguments = new StoreCreditAccountArgumentsBuilder(base.InnerQuery);
        }

        public StoreCreditAccountOperationQueryBuilder(IQuery<StoreCreditAccount> query) : base(query)
        {
            Arguments = new StoreCreditAccountArgumentsBuilder(base.InnerQuery);
        }

        public StoreCreditAccountOperationQueryBuilder Balance(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("balance");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public StoreCreditAccountOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public StoreCreditAccountOperationQueryBuilder Owner(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.HasStoreCreditAccountsQueryBuilder> build)
        {
            var query = new Query<IHasStoreCreditAccounts>("owner");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.HasStoreCreditAccountsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IHasStoreCreditAccounts>(query);
            return this;
        }

        public StoreCreditAccountOperationQueryBuilder Transactions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountTransactionConnectionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountTransactionConnection>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountTransactionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountTransactionConnection>(query);
            return this;
        }
    }
}