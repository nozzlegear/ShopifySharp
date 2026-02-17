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
    public sealed class SegmentConnectionQueryBuilder : FieldsQueryBuilderBase<SegmentConnection, SegmentConnectionQueryBuilder>
    {
        protected override SegmentConnectionQueryBuilder Self => this;

        public SegmentConnectionQueryBuilder() : this("segmentConnection")
        {
        }

        public SegmentConnectionQueryBuilder(string name) : base(new Query<SegmentConnection>(name))
        {
        }

        public SegmentConnectionQueryBuilder(IQuery<SegmentConnection> query) : base(query)
        {
        }

        public SegmentConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentEdgeQueryBuilder> build)
        {
            var query = new Query<SegmentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentEdge>(query);
            return this;
        }

        public SegmentConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentQueryBuilder> build)
        {
            var query = new Query<Segment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Segment>(query);
            return this;
        }

        public SegmentConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}