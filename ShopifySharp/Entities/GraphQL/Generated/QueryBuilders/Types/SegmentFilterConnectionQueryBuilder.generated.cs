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
    public sealed class SegmentFilterConnectionQueryBuilder : FieldsQueryBuilderBase<SegmentFilterConnection, SegmentFilterConnectionQueryBuilder>
    {
        protected override SegmentFilterConnectionQueryBuilder Self => this;

        public SegmentFilterConnectionQueryBuilder() : this("segmentFilterConnection")
        {
        }

        public SegmentFilterConnectionQueryBuilder(string name) : base(new Query<SegmentFilterConnection>(name))
        {
        }

        public SegmentFilterConnectionQueryBuilder(IQuery<SegmentFilterConnection> query) : base(query)
        {
        }

        public SegmentFilterConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentFilterEdgeQueryBuilder> build)
        {
            var query = new Query<SegmentFilterEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentFilterEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentFilterEdge>(query);
            return this;
        }

        public SegmentFilterConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentFilterQueryBuilder> build)
        {
            var query = new Query<ISegmentFilter>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentFilterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ISegmentFilter>(query);
            return this;
        }

        public SegmentFilterConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}