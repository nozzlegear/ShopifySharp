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
    public sealed class CommentQueryBuilder : FieldsQueryBuilderBase<Comment, CommentQueryBuilder>
    {
        protected override CommentQueryBuilder Self => this;

        public CommentQueryBuilder() : this("comment")
        {
        }

        public CommentQueryBuilder(string name) : base(new Query<Comment>(name))
        {
        }

        public CommentQueryBuilder(IQuery<Comment> query) : base(query)
        {
        }

        public CommentQueryBuilder Article(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleQueryBuilder> build)
        {
            var query = new Query<Article>("article");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Article>(query);
            return this;
        }

        public CommentQueryBuilder Author(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentAuthorQueryBuilder> build)
        {
            var query = new Query<CommentAuthor>("author");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentAuthorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CommentAuthor>(query);
            return this;
        }

        public CommentQueryBuilder Body()
        {
            base.InnerQuery.AddField("body");
            return this;
        }

        public CommentQueryBuilder BodyHtml()
        {
            base.InnerQuery.AddField("bodyHtml");
            return this;
        }

        public CommentQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CommentQueryBuilder Events(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public CommentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CommentQueryBuilder Ip()
        {
            base.InnerQuery.AddField("ip");
            return this;
        }

        public CommentQueryBuilder IsPublished()
        {
            base.InnerQuery.AddField("isPublished");
            return this;
        }

        public CommentQueryBuilder PublishedAt()
        {
            base.InnerQuery.AddField("publishedAt");
            return this;
        }

        public CommentQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public CommentQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public CommentQueryBuilder UserAgent()
        {
            base.InnerQuery.AddField("userAgent");
            return this;
        }
    }
}