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
    public sealed class QueryRootSegmentsQueryBuilder : FieldsQueryBuilderBase<SegmentConnection, QueryRootSegmentsQueryBuilder>, IHasArguments<QueryRootSegmentsArgumentsBuilder>
    {
        public QueryRootSegmentsArgumentsBuilder Arguments { get; }
        protected override QueryRootSegmentsQueryBuilder Self => this;

        public QueryRootSegmentsQueryBuilder(string name) : base(new Query<SegmentConnection>(name))
        {
            Arguments = new QueryRootSegmentsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSegmentsQueryBuilder(IQuery<SegmentConnection> query) : base(query)
        {
            Arguments = new QueryRootSegmentsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSegmentsQueryBuilder SetArguments(Action<QueryRootSegmentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootSegmentsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentEdgeQueryBuilder> build)
        {
            var query = new Query<SegmentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentEdge>(query);
            return this;
        }

        public QueryRootSegmentsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentQueryBuilder> build)
        {
            var query = new Query<Segment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Segment>(query);
            return this;
        }

        public QueryRootSegmentsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}