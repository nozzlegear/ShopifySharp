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
    public sealed class SearchResultEdgeQueryBuilder : FieldsQueryBuilderBase<SearchResultEdge, SearchResultEdgeQueryBuilder>
    {
        protected override SearchResultEdgeQueryBuilder Self => this;

        public SearchResultEdgeQueryBuilder() : this("searchResultEdge")
        {
        }

        public SearchResultEdgeQueryBuilder(string name) : base(new Query<SearchResultEdge>(name))
        {
        }

        public SearchResultEdgeQueryBuilder(IQuery<SearchResultEdge> query) : base(query)
        {
        }

        public SearchResultEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public SearchResultEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SearchResultQueryBuilder> build)
        {
            var query = new Query<SearchResult>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SearchResultQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SearchResult>(query);
            return this;
        }
    }
}