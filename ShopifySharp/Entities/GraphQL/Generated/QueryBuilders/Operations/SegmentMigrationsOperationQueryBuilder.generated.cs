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
    public sealed class SegmentMigrationsOperationQueryBuilder : FieldsQueryBuilderBase<SegmentMigrationConnection, SegmentMigrationsOperationQueryBuilder>, IGraphOperationQueryBuilder<SegmentMigrationConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public SegmentMigrationsArgumentsBuilder Arguments { get; }
        protected override SegmentMigrationsOperationQueryBuilder Self => this;

        public SegmentMigrationsOperationQueryBuilder() : this("segmentMigrations")
        {
        }

        public SegmentMigrationsOperationQueryBuilder(string name) : base(new Query<SegmentMigrationConnection>(name))
        {
            Arguments = new SegmentMigrationsArgumentsBuilder(base.InnerQuery);
        }

        public SegmentMigrationsOperationQueryBuilder(IQuery<SegmentMigrationConnection> query) : base(query)
        {
            Arguments = new SegmentMigrationsArgumentsBuilder(base.InnerQuery);
        }

        public SegmentMigrationsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentMigrationEdgeQueryBuilder> build)
        {
            var query = new Query<SegmentMigrationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentMigrationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentMigrationEdge>(query);
            return this;
        }

        public SegmentMigrationsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentMigrationQueryBuilder> build)
        {
            var query = new Query<SegmentMigration>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentMigrationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentMigration>(query);
            return this;
        }

        public SegmentMigrationsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}