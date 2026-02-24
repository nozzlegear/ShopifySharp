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
    public sealed class QueryRootCommentQueryBuilder : FieldsQueryBuilderBase<Comment, QueryRootCommentQueryBuilder>, IHasArguments<QueryRootCommentArgumentsBuilder>
    {
        public QueryRootCommentArgumentsBuilder Arguments { get; }
        protected override QueryRootCommentQueryBuilder Self => this;

        public QueryRootCommentQueryBuilder(string name) : base(new Query<Comment>(name))
        {
            Arguments = new QueryRootCommentArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCommentQueryBuilder(IQuery<Comment> query) : base(query)
        {
            Arguments = new QueryRootCommentArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCommentQueryBuilder SetArguments(Action<QueryRootCommentArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCommentQueryBuilder Article(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ArticleQueryBuilder> build)
        {
            var query = new Query<Article>("article");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ArticleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Article>(query);
            return this;
        }

        public QueryRootCommentQueryBuilder Author(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CommentAuthorQueryBuilder> build)
        {
            var query = new Query<CommentAuthor>("author");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CommentAuthorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CommentAuthor>(query);
            return this;
        }

        public QueryRootCommentQueryBuilder Body()
        {
            base.InnerQuery.AddField("body");
            return this;
        }

        public QueryRootCommentQueryBuilder BodyHtml()
        {
            base.InnerQuery.AddField("bodyHtml");
            return this;
        }

        public QueryRootCommentQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootCommentQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public QueryRootCommentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootCommentQueryBuilder Ip()
        {
            base.InnerQuery.AddField("ip");
            return this;
        }

        public QueryRootCommentQueryBuilder IsPublished()
        {
            base.InnerQuery.AddField("isPublished");
            return this;
        }

        public QueryRootCommentQueryBuilder PublishedAt()
        {
            base.InnerQuery.AddField("publishedAt");
            return this;
        }

        public QueryRootCommentQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public QueryRootCommentQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public QueryRootCommentQueryBuilder UserAgent()
        {
            base.InnerQuery.AddField("userAgent");
            return this;
        }
    }
}