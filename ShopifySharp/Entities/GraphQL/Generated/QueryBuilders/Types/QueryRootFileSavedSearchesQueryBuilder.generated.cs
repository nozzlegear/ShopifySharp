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
    public sealed class QueryRootFileSavedSearchesQueryBuilder : FieldsQueryBuilderBase<SavedSearchConnection, QueryRootFileSavedSearchesQueryBuilder>, IHasArguments<QueryRootFileSavedSearchesArgumentsBuilder>
    {
        public QueryRootFileSavedSearchesArgumentsBuilder Arguments { get; }
        protected override QueryRootFileSavedSearchesQueryBuilder Self => this;

        public QueryRootFileSavedSearchesQueryBuilder(string name) : base(new Query<SavedSearchConnection>(name))
        {
            Arguments = new QueryRootFileSavedSearchesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootFileSavedSearchesQueryBuilder(IQuery<SavedSearchConnection> query) : base(query)
        {
            Arguments = new QueryRootFileSavedSearchesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootFileSavedSearchesQueryBuilder SetArguments(Action<QueryRootFileSavedSearchesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootFileSavedSearchesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SavedSearchEdgeQueryBuilder> build)
        {
            var query = new Query<SavedSearchEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SavedSearchEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearchEdge>(query);
            return this;
        }

        public QueryRootFileSavedSearchesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SavedSearchQueryBuilder> build)
        {
            var query = new Query<SavedSearch>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SavedSearchQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearch>(query);
            return this;
        }

        public QueryRootFileSavedSearchesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}