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
    public sealed class BulkOperationsOperationQueryBuilder : FieldsQueryBuilderBase<BulkOperationConnection, BulkOperationsOperationQueryBuilder>, IGraphOperationQueryBuilder<BulkOperationConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public BulkOperationsArgumentsBuilder Arguments { get; }
        protected override BulkOperationsOperationQueryBuilder Self => this;

        public BulkOperationsOperationQueryBuilder() : this("bulkOperations")
        {
        }

        public BulkOperationsOperationQueryBuilder(string name) : base(new Query<BulkOperationConnection>(name))
        {
            Arguments = new BulkOperationsArgumentsBuilder(base.InnerQuery);
        }

        public BulkOperationsOperationQueryBuilder(IQuery<BulkOperationConnection> query) : base(query)
        {
            Arguments = new BulkOperationsArgumentsBuilder(base.InnerQuery);
        }

        public BulkOperationsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BulkOperationEdgeQueryBuilder> build)
        {
            var query = new Query<BulkOperationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BulkOperationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkOperationEdge>(query);
            return this;
        }

        public BulkOperationsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BulkOperationQueryBuilder> build)
        {
            var query = new Query<BulkOperation>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BulkOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkOperation>(query);
            return this;
        }

        public BulkOperationsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}