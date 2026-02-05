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

        public TenderTransactionsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TenderTransactionEdgeQueryBuilder> build)
        {
            var query = new Query<TenderTransactionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TenderTransactionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TenderTransactionEdge>(query);
            return this;
        }

        public TenderTransactionsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TenderTransactionQueryBuilder> build)
        {
            var query = new Query<TenderTransaction>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TenderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TenderTransaction>(query);
            return this;
        }

        public TenderTransactionsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}