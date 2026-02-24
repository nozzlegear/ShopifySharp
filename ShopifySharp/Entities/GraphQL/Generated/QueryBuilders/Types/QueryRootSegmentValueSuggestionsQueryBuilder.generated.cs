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
    public sealed class QueryRootSegmentValueSuggestionsQueryBuilder : FieldsQueryBuilderBase<SegmentValueConnection, QueryRootSegmentValueSuggestionsQueryBuilder>, IHasArguments<QueryRootSegmentValueSuggestionsArgumentsBuilder>
    {
        public QueryRootSegmentValueSuggestionsArgumentsBuilder Arguments { get; }
        protected override QueryRootSegmentValueSuggestionsQueryBuilder Self => this;

        public QueryRootSegmentValueSuggestionsQueryBuilder(string name) : base(new Query<SegmentValueConnection>(name))
        {
            Arguments = new QueryRootSegmentValueSuggestionsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSegmentValueSuggestionsQueryBuilder(IQuery<SegmentValueConnection> query) : base(query)
        {
            Arguments = new QueryRootSegmentValueSuggestionsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSegmentValueSuggestionsQueryBuilder SetArguments(Action<QueryRootSegmentValueSuggestionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootSegmentValueSuggestionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentValueEdgeQueryBuilder> build)
        {
            var query = new Query<SegmentValueEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentValueEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentValueEdge>(query);
            return this;
        }

        public QueryRootSegmentValueSuggestionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentValueQueryBuilder> build)
        {
            var query = new Query<SegmentValue>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentValue>(query);
            return this;
        }

        public QueryRootSegmentValueSuggestionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}