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
    public sealed class BlogQueryBuilder : FieldsQueryBuilderBase<Blog, BlogQueryBuilder>
    {
        protected override BlogQueryBuilder Self => this;

        public BlogQueryBuilder() : this("blog")
        {
        }

        public BlogQueryBuilder(string name) : base(new Query<Blog>(name))
        {
        }

        public BlogQueryBuilder(IQuery<Blog> query) : base(query)
        {
        }

        public BlogQueryBuilder Articles(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ArticleConnectionQueryBuilder> build)
        {
            var query = new Query<ArticleConnection>("articles");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ArticleConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ArticleConnection>(query);
            return this;
        }

        public BlogQueryBuilder ArticlesCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("articlesCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public BlogQueryBuilder CommentPolicy()
        {
            base.InnerQuery.AddField("commentPolicy");
            return this;
        }

        public BlogQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public BlogQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public BlogQueryBuilder Feed(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BlogFeedQueryBuilder> build)
        {
            var query = new Query<BlogFeed>("feed");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BlogFeedQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BlogFeed>(query);
            return this;
        }

        public BlogQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public BlogQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public BlogQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public BlogQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public BlogQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public BlogQueryBuilder Tags()
        {
            base.InnerQuery.AddField("tags");
            return this;
        }

        public BlogQueryBuilder TemplateSuffix()
        {
            base.InnerQuery.AddField("templateSuffix");
            return this;
        }

        public BlogQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public BlogQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public BlogQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}