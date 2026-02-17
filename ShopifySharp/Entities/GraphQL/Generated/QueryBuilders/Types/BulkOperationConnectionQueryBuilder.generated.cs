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
    public sealed class BulkOperationConnectionQueryBuilder : FieldsQueryBuilderBase<BulkOperationConnection, BulkOperationConnectionQueryBuilder>
    {
        protected override BulkOperationConnectionQueryBuilder Self => this;

        public BulkOperationConnectionQueryBuilder() : this("bulkOperationConnection")
        {
        }

        public BulkOperationConnectionQueryBuilder(string name) : base(new Query<BulkOperationConnection>(name))
        {
        }

        public BulkOperationConnectionQueryBuilder(IQuery<BulkOperationConnection> query) : base(query)
        {
        }

        public BulkOperationConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BulkOperationEdgeQueryBuilder> build)
        {
            var query = new Query<BulkOperationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BulkOperationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkOperationEdge>(query);
            return this;
        }

        public BulkOperationConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BulkOperationQueryBuilder> build)
        {
            var query = new Query<BulkOperation>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BulkOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkOperation>(query);
            return this;
        }

        public BulkOperationConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}