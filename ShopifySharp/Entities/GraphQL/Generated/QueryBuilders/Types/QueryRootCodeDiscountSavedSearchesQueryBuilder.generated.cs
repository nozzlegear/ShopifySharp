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
    public sealed class QueryRootCodeDiscountSavedSearchesQueryBuilder : FieldsQueryBuilderBase<SavedSearchConnection, QueryRootCodeDiscountSavedSearchesQueryBuilder>, IHasArguments<QueryRootCodeDiscountSavedSearchesArgumentsBuilder>
    {
        public QueryRootCodeDiscountSavedSearchesArgumentsBuilder Arguments { get; }
        protected override QueryRootCodeDiscountSavedSearchesQueryBuilder Self => this;

        public QueryRootCodeDiscountSavedSearchesQueryBuilder(string name) : base(new Query<SavedSearchConnection>(name))
        {
            Arguments = new QueryRootCodeDiscountSavedSearchesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCodeDiscountSavedSearchesQueryBuilder(IQuery<SavedSearchConnection> query) : base(query)
        {
            Arguments = new QueryRootCodeDiscountSavedSearchesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCodeDiscountSavedSearchesQueryBuilder SetArguments(Action<QueryRootCodeDiscountSavedSearchesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCodeDiscountSavedSearchesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SavedSearchEdgeQueryBuilder> build)
        {
            var query = new Query<SavedSearchEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SavedSearchEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearchEdge>(query);
            return this;
        }

        public QueryRootCodeDiscountSavedSearchesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SavedSearchQueryBuilder> build)
        {
            var query = new Query<SavedSearch>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SavedSearchQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearch>(query);
            return this;
        }

        public QueryRootCodeDiscountSavedSearchesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}