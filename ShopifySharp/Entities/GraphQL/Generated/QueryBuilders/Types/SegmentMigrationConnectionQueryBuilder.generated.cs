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
    public sealed class SegmentMigrationConnectionQueryBuilder : FieldsQueryBuilderBase<SegmentMigrationConnection, SegmentMigrationConnectionQueryBuilder>
    {
        protected override SegmentMigrationConnectionQueryBuilder Self => this;

        public SegmentMigrationConnectionQueryBuilder() : this("segmentMigrationConnection")
        {
        }

        public SegmentMigrationConnectionQueryBuilder(string name) : base(new Query<SegmentMigrationConnection>(name))
        {
        }

        public SegmentMigrationConnectionQueryBuilder(IQuery<SegmentMigrationConnection> query) : base(query)
        {
        }

        public SegmentMigrationConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentMigrationEdgeQueryBuilder> build)
        {
            var query = new Query<SegmentMigrationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentMigrationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentMigrationEdge>(query);
            return this;
        }

        public SegmentMigrationConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentMigrationQueryBuilder> build)
        {
            var query = new Query<SegmentMigration>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentMigrationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentMigration>(query);
            return this;
        }

        public SegmentMigrationConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}