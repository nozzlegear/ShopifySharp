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
    public sealed class ShopifyPaymentsAccountBalanceTransactionsQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsBalanceTransactionConnection, ShopifyPaymentsAccountBalanceTransactionsQueryBuilder>, IHasArguments<ShopifyPaymentsAccountBalanceTransactionsArgumentsBuilder>
    {
        public ShopifyPaymentsAccountBalanceTransactionsArgumentsBuilder Arguments { get; }
        protected override ShopifyPaymentsAccountBalanceTransactionsQueryBuilder Self => this;

        public ShopifyPaymentsAccountBalanceTransactionsQueryBuilder(string name) : base(new Query<ShopifyPaymentsBalanceTransactionConnection>(name))
        {
            Arguments = new ShopifyPaymentsAccountBalanceTransactionsArgumentsBuilder(base.InnerQuery);
        }

        public ShopifyPaymentsAccountBalanceTransactionsQueryBuilder(IQuery<ShopifyPaymentsBalanceTransactionConnection> query) : base(query)
        {
            Arguments = new ShopifyPaymentsAccountBalanceTransactionsArgumentsBuilder(base.InnerQuery);
        }

        public ShopifyPaymentsAccountBalanceTransactionsQueryBuilder SetArguments(Action<ShopifyPaymentsAccountBalanceTransactionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ShopifyPaymentsAccountBalanceTransactionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsBalanceTransactionEdgeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsBalanceTransactionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsBalanceTransactionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsBalanceTransactionEdge>(query);
            return this;
        }

        public ShopifyPaymentsAccountBalanceTransactionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsBalanceTransactionQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsBalanceTransaction>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsBalanceTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsBalanceTransaction>(query);
            return this;
        }

        public ShopifyPaymentsAccountBalanceTransactionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}