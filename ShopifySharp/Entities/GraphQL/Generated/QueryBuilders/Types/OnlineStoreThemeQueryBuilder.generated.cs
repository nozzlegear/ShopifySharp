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
    public sealed class OnlineStoreThemeQueryBuilder : FieldsQueryBuilderBase<OnlineStoreTheme, OnlineStoreThemeQueryBuilder>
    {
        protected override OnlineStoreThemeQueryBuilder Self => this;

        public OnlineStoreThemeQueryBuilder() : this("onlineStoreTheme")
        {
        }

        public OnlineStoreThemeQueryBuilder(string name) : base(new Query<OnlineStoreTheme>(name))
        {
        }

        public OnlineStoreThemeQueryBuilder(IQuery<OnlineStoreTheme> query) : base(query)
        {
        }

        public OnlineStoreThemeQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public OnlineStoreThemeQueryBuilder Files(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileConnectionQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFileConnection>("files");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreThemeFileConnection>(query);
            return this;
        }

        public OnlineStoreThemeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public OnlineStoreThemeQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public OnlineStoreThemeQueryBuilder Prefix()
        {
            base.InnerQuery.AddField("prefix");
            return this;
        }

        public OnlineStoreThemeQueryBuilder Processing()
        {
            base.InnerQuery.AddField("processing");
            return this;
        }

        public OnlineStoreThemeQueryBuilder ProcessingFailed()
        {
            base.InnerQuery.AddField("processingFailed");
            return this;
        }

        public OnlineStoreThemeQueryBuilder Role()
        {
            base.InnerQuery.AddField("role");
            return this;
        }

        public OnlineStoreThemeQueryBuilder ThemeStoreId()
        {
            base.InnerQuery.AddField("themeStoreId");
            return this;
        }

        public OnlineStoreThemeQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public OnlineStoreThemeQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}