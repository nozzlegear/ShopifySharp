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
    public sealed class SearchResultConnectionQueryBuilder : FieldsQueryBuilderBase<SearchResultConnection, SearchResultConnectionQueryBuilder>
    {
        protected override SearchResultConnectionQueryBuilder Self => this;

        public SearchResultConnectionQueryBuilder() : this("searchResultConnection")
        {
        }

        public SearchResultConnectionQueryBuilder(string name) : base(new Query<SearchResultConnection>(name))
        {
        }

        public SearchResultConnectionQueryBuilder(IQuery<SearchResultConnection> query) : base(query)
        {
        }

        public SearchResultConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SearchResultEdgeQueryBuilder> build)
        {
            var query = new Query<SearchResultEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SearchResultEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SearchResultEdge>(query);
            return this;
        }

        public SearchResultConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        [Obsolete("The provided information is not accurate.")]
        public SearchResultConnectionQueryBuilder ResultsAfterCount()
        {
            base.InnerQuery.AddField("resultsAfterCount");
            return this;
        }
    }
}