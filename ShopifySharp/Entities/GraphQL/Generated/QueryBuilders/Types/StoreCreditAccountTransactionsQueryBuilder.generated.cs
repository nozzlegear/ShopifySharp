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
    public sealed class StoreCreditAccountTransactionsQueryBuilder : FieldsQueryBuilderBase<StoreCreditAccountTransactionConnection, StoreCreditAccountTransactionsQueryBuilder>, IHasArguments<StoreCreditAccountTransactionsArgumentsBuilder>
    {
        public StoreCreditAccountTransactionsArgumentsBuilder Arguments { get; }
        protected override StoreCreditAccountTransactionsQueryBuilder Self => this;

        public StoreCreditAccountTransactionsQueryBuilder(string name) : base(new Query<StoreCreditAccountTransactionConnection>(name))
        {
            Arguments = new StoreCreditAccountTransactionsArgumentsBuilder(base.InnerQuery);
        }

        public StoreCreditAccountTransactionsQueryBuilder(IQuery<StoreCreditAccountTransactionConnection> query) : base(query)
        {
            Arguments = new StoreCreditAccountTransactionsArgumentsBuilder(base.InnerQuery);
        }

        public StoreCreditAccountTransactionsQueryBuilder SetArguments(Action<StoreCreditAccountTransactionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public StoreCreditAccountTransactionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountTransactionEdgeQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountTransactionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountTransactionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountTransactionEdge>(query);
            return this;
        }

        public StoreCreditAccountTransactionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountTransactionQueryBuilder> build)
        {
            var query = new Query<IStoreCreditAccountTransaction>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IStoreCreditAccountTransaction>(query);
            return this;
        }

        public StoreCreditAccountTransactionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}