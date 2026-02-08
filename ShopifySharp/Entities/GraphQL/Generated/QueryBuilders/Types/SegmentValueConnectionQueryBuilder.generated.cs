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
    public sealed class SegmentValueConnectionQueryBuilder : FieldsQueryBuilderBase<SegmentValueConnection, SegmentValueConnectionQueryBuilder>
    {
        protected override SegmentValueConnectionQueryBuilder Self => this;

        public SegmentValueConnectionQueryBuilder() : this("segmentValueConnection")
        {
        }

        public SegmentValueConnectionQueryBuilder(string name) : base(new Query<SegmentValueConnection>(name))
        {
        }

        public SegmentValueConnectionQueryBuilder(IQuery<SegmentValueConnection> query) : base(query)
        {
        }

        public SegmentValueConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentValueEdgeQueryBuilder> build)
        {
            var query = new Query<SegmentValueEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentValueEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentValueEdge>(query);
            return this;
        }

        public SegmentValueConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentValueQueryBuilder> build)
        {
            var query = new Query<SegmentValue>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SegmentValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentValue>(query);
            return this;
        }

        public SegmentValueConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}