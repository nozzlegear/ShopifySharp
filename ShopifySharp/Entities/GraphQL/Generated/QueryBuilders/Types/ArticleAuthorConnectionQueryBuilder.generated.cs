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
    public sealed class ArticleAuthorConnectionQueryBuilder : FieldsQueryBuilderBase<ArticleAuthorConnection, ArticleAuthorConnectionQueryBuilder>
    {
        protected override ArticleAuthorConnectionQueryBuilder Self => this;

        public ArticleAuthorConnectionQueryBuilder() : this("articleAuthorConnection")
        {
        }

        public ArticleAuthorConnectionQueryBuilder(string name) : base(new Query<ArticleAuthorConnection>(name))
        {
        }

        public ArticleAuthorConnectionQueryBuilder(IQuery<ArticleAuthorConnection> query) : base(query)
        {
        }

        public ArticleAuthorConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleAuthorEdgeQueryBuilder> build)
        {
            var query = new Query<ArticleAuthorEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleAuthorEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ArticleAuthorEdge>(query);
            return this;
        }

        public ArticleAuthorConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleAuthorQueryBuilder> build)
        {
            var query = new Query<ArticleAuthor>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleAuthorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ArticleAuthor>(query);
            return this;
        }

        public ArticleAuthorConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}