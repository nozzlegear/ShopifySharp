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
    public sealed class BulkOperationEdgeQueryBuilder : FieldsQueryBuilderBase<BulkOperationEdge, BulkOperationEdgeQueryBuilder>
    {
        protected override BulkOperationEdgeQueryBuilder Self => this;

        public BulkOperationEdgeQueryBuilder() : this("bulkOperationEdge")
        {
        }

        public BulkOperationEdgeQueryBuilder(string name) : base(new Query<BulkOperationEdge>(name))
        {
        }

        public BulkOperationEdgeQueryBuilder(IQuery<BulkOperationEdge> query) : base(query)
        {
        }

        public BulkOperationEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public BulkOperationEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationQueryBuilder> build)
        {
            var query = new Query<BulkOperation>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BulkOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BulkOperation>(query);
            return this;
        }
    }
}