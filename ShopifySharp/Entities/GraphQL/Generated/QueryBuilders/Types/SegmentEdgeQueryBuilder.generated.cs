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
    public sealed class SegmentEdgeQueryBuilder : FieldsQueryBuilderBase<SegmentEdge, SegmentEdgeQueryBuilder>
    {
        protected override SegmentEdgeQueryBuilder Self => this;

        public SegmentEdgeQueryBuilder() : this("segmentEdge")
        {
        }

        public SegmentEdgeQueryBuilder(string name) : base(new Query<SegmentEdge>(name))
        {
        }

        public SegmentEdgeQueryBuilder(IQuery<SegmentEdge> query) : base(query)
        {
        }

        public SegmentEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public SegmentEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentQueryBuilder> build)
        {
            var query = new Query<Segment>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Segment>(query);
            return this;
        }
    }
}