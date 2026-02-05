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
    public sealed class SegmentValueEdgeQueryBuilder : FieldsQueryBuilderBase<SegmentValueEdge, SegmentValueEdgeQueryBuilder>
    {
        protected override SegmentValueEdgeQueryBuilder Self => this;

        public SegmentValueEdgeQueryBuilder() : this("segmentValueEdge")
        {
        }

        public SegmentValueEdgeQueryBuilder(string name) : base(new Query<SegmentValueEdge>(name))
        {
        }

        public SegmentValueEdgeQueryBuilder(IQuery<SegmentValueEdge> query) : base(query)
        {
        }

        public SegmentValueEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public SegmentValueEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentValueQueryBuilder> build)
        {
            var query = new Query<SegmentValue>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentValue>(query);
            return this;
        }
    }
}