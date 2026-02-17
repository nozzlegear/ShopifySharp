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
    public sealed class SearchResultQueryBuilder : FieldsQueryBuilderBase<SearchResult, SearchResultQueryBuilder>
    {
        protected override SearchResultQueryBuilder Self => this;

        public SearchResultQueryBuilder() : this("searchResult")
        {
        }

        public SearchResultQueryBuilder(string name) : base(new Query<SearchResult>(name))
        {
        }

        public SearchResultQueryBuilder(IQuery<SearchResult> query) : base(query)
        {
        }

        public SearchResultQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public SearchResultQueryBuilder Image(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public SearchResultQueryBuilder Reference(Action<ShopifySharp.GraphQL.QueryBuilders.Types.NodeQueryBuilder> build)
        {
            var query = new Query<INode>("reference");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.NodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<INode>(query);
            return this;
        }

        public SearchResultQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public SearchResultQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}