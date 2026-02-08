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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class ArticleOperationQueryBuilder : FieldsQueryBuilderBase<Article, ArticleOperationQueryBuilder>, IGraphOperationQueryBuilder<Article>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ArticleArgumentsBuilder Arguments { get; }
        protected override ArticleOperationQueryBuilder Self => this;

        public ArticleOperationQueryBuilder() : this("article")
        {
        }

        public ArticleOperationQueryBuilder(string name) : base(new Query<Article>(name))
        {
            Arguments = new ArticleArgumentsBuilder(base.InnerQuery);
        }

        public ArticleOperationQueryBuilder(IQuery<Article> query) : base(query)
        {
            Arguments = new ArticleArgumentsBuilder(base.InnerQuery);
        }

        public ArticleOperationQueryBuilder Author(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleAuthorQueryBuilder> build)
        {
            var query = new Query<ArticleAuthor>("author");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleAuthorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ArticleAuthor>(query);
            return this;
        }

        public ArticleOperationQueryBuilder Blog(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogQueryBuilder> build)
        {
            var query = new Query<Blog>("blog");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BlogQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Blog>(query);
            return this;
        }

        public ArticleOperationQueryBuilder Body()
        {
            base.InnerQuery.AddField("body");
            return this;
        }

        public ArticleOperationQueryBuilder Comments(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentConnectionQueryBuilder> build)
        {
            var query = new Query<CommentConnection>("comments");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CommentConnection>(query);
            return this;
        }

        public ArticleOperationQueryBuilder CommentsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("commentsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public ArticleOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public ArticleOperationQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public ArticleOperationQueryBuilder Events(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public ArticleOperationQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public ArticleOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ArticleOperationQueryBuilder Image(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public ArticleOperationQueryBuilder IsPublished()
        {
            base.InnerQuery.AddField("isPublished");
            return this;
        }

        public ArticleOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public ArticleOperationQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public ArticleOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public ArticleOperationQueryBuilder PublishedAt()
        {
            base.InnerQuery.AddField("publishedAt");
            return this;
        }

        public ArticleOperationQueryBuilder Summary()
        {
            base.InnerQuery.AddField("summary");
            return this;
        }

        public ArticleOperationQueryBuilder Tags()
        {
            base.InnerQuery.AddField("tags");
            return this;
        }

        public ArticleOperationQueryBuilder TemplateSuffix()
        {
            base.InnerQuery.AddField("templateSuffix");
            return this;
        }

        public ArticleOperationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public ArticleOperationQueryBuilder Translations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public ArticleOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}