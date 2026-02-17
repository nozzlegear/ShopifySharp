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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CommentOperationQueryBuilder : FieldsQueryBuilderBase<Comment, CommentOperationQueryBuilder>, IGraphOperationQueryBuilder<Comment>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CommentArgumentsBuilder Arguments { get; }
        protected override CommentOperationQueryBuilder Self => this;

        public CommentOperationQueryBuilder() : this("comment")
        {
        }

        public CommentOperationQueryBuilder(string name) : base(new Query<Comment>(name))
        {
            Arguments = new CommentArgumentsBuilder(base.InnerQuery);
        }

        public CommentOperationQueryBuilder(IQuery<Comment> query) : base(query)
        {
            Arguments = new CommentArgumentsBuilder(base.InnerQuery);
        }

        public CommentOperationQueryBuilder Article(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ArticleQueryBuilder> build)
        {
            var query = new Query<Article>("article");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ArticleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Article>(query);
            return this;
        }

        public CommentOperationQueryBuilder Author(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CommentAuthorQueryBuilder> build)
        {
            var query = new Query<CommentAuthor>("author");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CommentAuthorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CommentAuthor>(query);
            return this;
        }

        public CommentOperationQueryBuilder Body()
        {
            base.InnerQuery.AddField("body");
            return this;
        }

        public CommentOperationQueryBuilder BodyHtml()
        {
            base.InnerQuery.AddField("bodyHtml");
            return this;
        }

        public CommentOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CommentOperationQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public CommentOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CommentOperationQueryBuilder Ip()
        {
            base.InnerQuery.AddField("ip");
            return this;
        }

        public CommentOperationQueryBuilder IsPublished()
        {
            base.InnerQuery.AddField("isPublished");
            return this;
        }

        public CommentOperationQueryBuilder PublishedAt()
        {
            base.InnerQuery.AddField("publishedAt");
            return this;
        }

        public CommentOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public CommentOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public CommentOperationQueryBuilder UserAgent()
        {
            base.InnerQuery.AddField("userAgent");
            return this;
        }
    }
}