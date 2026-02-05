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
    public sealed class SegmentMigrationEdgeQueryBuilder : FieldsQueryBuilderBase<SegmentMigrationEdge, SegmentMigrationEdgeQueryBuilder>
    {
        protected override SegmentMigrationEdgeQueryBuilder Self => this;

        public SegmentMigrationEdgeQueryBuilder() : this("segmentMigrationEdge")
        {
        }

        public SegmentMigrationEdgeQueryBuilder(string name) : base(new Query<SegmentMigrationEdge>(name))
        {
        }

        public SegmentMigrationEdgeQueryBuilder(IQuery<SegmentMigrationEdge> query) : base(query)
        {
        }

        public SegmentMigrationEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public SegmentMigrationEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentMigrationQueryBuilder> build)
        {
            var query = new Query<SegmentMigration>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentMigrationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentMigration>(query);
            return this;
        }
    }
}