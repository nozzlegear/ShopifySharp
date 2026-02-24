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
    public sealed class QueryRootSegmentFilterSuggestionsQueryBuilder : FieldsQueryBuilderBase<SegmentFilterConnection, QueryRootSegmentFilterSuggestionsQueryBuilder>, IHasArguments<QueryRootSegmentFilterSuggestionsArgumentsBuilder>
    {
        public QueryRootSegmentFilterSuggestionsArgumentsBuilder Arguments { get; }
        protected override QueryRootSegmentFilterSuggestionsQueryBuilder Self => this;

        public QueryRootSegmentFilterSuggestionsQueryBuilder(string name) : base(new Query<SegmentFilterConnection>(name))
        {
            Arguments = new QueryRootSegmentFilterSuggestionsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSegmentFilterSuggestionsQueryBuilder(IQuery<SegmentFilterConnection> query) : base(query)
        {
            Arguments = new QueryRootSegmentFilterSuggestionsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSegmentFilterSuggestionsQueryBuilder SetArguments(Action<QueryRootSegmentFilterSuggestionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootSegmentFilterSuggestionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentFilterEdgeQueryBuilder> build)
        {
            var query = new Query<SegmentFilterEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentFilterEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentFilterEdge>(query);
            return this;
        }

        public QueryRootSegmentFilterSuggestionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentFilterQueryBuilder> build)
        {
            var query = new Query<ISegmentFilter>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentFilterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ISegmentFilter>(query);
            return this;
        }

        public QueryRootSegmentFilterSuggestionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}