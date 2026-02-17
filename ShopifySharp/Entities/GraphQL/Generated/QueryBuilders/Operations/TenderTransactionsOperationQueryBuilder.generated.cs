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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class TenderTransactionsOperationQueryBuilder : FieldsQueryBuilderBase<TenderTransactionConnection, TenderTransactionsOperationQueryBuilder>, IGraphOperationQueryBuilder<TenderTransactionConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public TenderTransactionsArgumentsBuilder Arguments { get; }
        protected override TenderTransactionsOperationQueryBuilder Self => this;

        public TenderTransactionsOperationQueryBuilder() : this("tenderTransactions")
        {
        }

        public TenderTransactionsOperationQueryBuilder(string name) : base(new Query<TenderTransactionConnection>(name))
        {
            Arguments = new TenderTransactionsArgumentsBuilder(base.InnerQuery);
        }

        public TenderTransactionsOperationQueryBuilder(IQuery<TenderTransactionConnection> query) : base(query)
        {
            Arguments = new TenderTransactionsArgumentsBuilder(base.InnerQuery);
        }

        public TenderTransactionsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TenderTransactionEdgeQueryBuilder> build)
        {
            var query = new Query<TenderTransactionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TenderTransactionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TenderTransactionEdge>(query);
            return this;
        }

        public TenderTransactionsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TenderTransactionQueryBuilder> build)
        {
            var query = new Query<TenderTransaction>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TenderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TenderTransaction>(query);
            return this;
        }

        public TenderTransactionsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}