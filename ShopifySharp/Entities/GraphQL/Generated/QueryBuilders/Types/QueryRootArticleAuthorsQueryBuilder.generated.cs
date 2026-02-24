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
    public sealed class QueryRootArticleAuthorsQueryBuilder : FieldsQueryBuilderBase<ArticleAuthorConnection, QueryRootArticleAuthorsQueryBuilder>, IHasArguments<QueryRootArticleAuthorsArgumentsBuilder>
    {
        public QueryRootArticleAuthorsArgumentsBuilder Arguments { get; }
        protected override QueryRootArticleAuthorsQueryBuilder Self => this;

        public QueryRootArticleAuthorsQueryBuilder(string name) : base(new Query<ArticleAuthorConnection>(name))
        {
            Arguments = new QueryRootArticleAuthorsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootArticleAuthorsQueryBuilder(IQuery<ArticleAuthorConnection> query) : base(query)
        {
            Arguments = new QueryRootArticleAuthorsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootArticleAuthorsQueryBuilder SetArguments(Action<QueryRootArticleAuthorsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootArticleAuthorsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ArticleAuthorEdgeQueryBuilder> build)
        {
            var query = new Query<ArticleAuthorEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ArticleAuthorEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ArticleAuthorEdge>(query);
            return this;
        }

        public QueryRootArticleAuthorsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ArticleAuthorQueryBuilder> build)
        {
            var query = new Query<ArticleAuthor>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ArticleAuthorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ArticleAuthor>(query);
            return this;
        }

        public QueryRootArticleAuthorsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}