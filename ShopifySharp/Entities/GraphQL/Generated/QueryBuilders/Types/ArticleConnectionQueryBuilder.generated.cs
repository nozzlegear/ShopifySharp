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
    public sealed class ArticleConnectionQueryBuilder : FieldsQueryBuilderBase<ArticleConnection, ArticleConnectionQueryBuilder>
    {
        protected override ArticleConnectionQueryBuilder Self => this;

        public ArticleConnectionQueryBuilder() : this("articleConnection")
        {
        }

        public ArticleConnectionQueryBuilder(string name) : base(new Query<ArticleConnection>(name))
        {
        }

        public ArticleConnectionQueryBuilder(IQuery<ArticleConnection> query) : base(query)
        {
        }

        public ArticleConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ArticleEdgeQueryBuilder> build)
        {
            var query = new Query<ArticleEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ArticleEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ArticleEdge>(query);
            return this;
        }

        public ArticleConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ArticleQueryBuilder> build)
        {
            var query = new Query<Article>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ArticleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Article>(query);
            return this;
        }

        public ArticleConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}