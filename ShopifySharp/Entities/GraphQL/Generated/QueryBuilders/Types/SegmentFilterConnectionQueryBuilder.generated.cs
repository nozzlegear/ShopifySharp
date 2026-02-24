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
    public sealed class SegmentFilterConnectionQueryBuilder : FieldsQueryBuilderBase<SegmentFilterConnection, SegmentFilterConnectionQueryBuilder>, IHasArguments<SegmentFilterConnectionArgumentsBuilder>
    {
        public SegmentFilterConnectionArgumentsBuilder Arguments { get; }
        protected override SegmentFilterConnectionQueryBuilder Self => this;

        public SegmentFilterConnectionQueryBuilder() : this("segmentFilterConnection")
        {
        }

        public SegmentFilterConnectionQueryBuilder(string name) : base(new Query<SegmentFilterConnection>(name))
        {
            Arguments = new SegmentFilterConnectionArgumentsBuilder(base.InnerQuery);
        }

        public SegmentFilterConnectionQueryBuilder(IQuery<SegmentFilterConnection> query) : base(query)
        {
            Arguments = new SegmentFilterConnectionArgumentsBuilder(base.InnerQuery);
        }

        public SegmentFilterConnectionQueryBuilder SetArguments(Action<SegmentFilterConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SegmentFilterConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentFilterEdgeQueryBuilder> build)
        {
            var query = new Query<SegmentFilterEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentFilterEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentFilterEdge>(query);
            return this;
        }

        public SegmentFilterConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentFilterQueryBuilder> build)
        {
            var query = new Query<ISegmentFilter>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentFilterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ISegmentFilter>(query);
            return this;
        }

        public SegmentFilterConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}