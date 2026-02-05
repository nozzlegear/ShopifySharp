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
    public sealed class SegmentFilterEdgeQueryBuilder : FieldsQueryBuilderBase<SegmentFilterEdge, SegmentFilterEdgeQueryBuilder>
    {
        protected override SegmentFilterEdgeQueryBuilder Self => this;

        public SegmentFilterEdgeQueryBuilder() : this("segmentFilterEdge")
        {
        }

        public SegmentFilterEdgeQueryBuilder(string name) : base(new Query<SegmentFilterEdge>(name))
        {
        }

        public SegmentFilterEdgeQueryBuilder(IQuery<SegmentFilterEdge> query) : base(query)
        {
        }

        public SegmentFilterEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public SegmentFilterEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentFilterQueryBuilder> build)
        {
            var query = new Query<ISegmentFilter>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentFilterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ISegmentFilter>(query);
            return this;
        }
    }
}