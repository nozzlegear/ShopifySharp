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
    public sealed class ThemeOperationQueryBuilder : FieldsQueryBuilderBase<OnlineStoreTheme, ThemeOperationQueryBuilder>, IGraphOperationQueryBuilder<OnlineStoreTheme>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ThemeArgumentsBuilder Arguments { get; }
        protected override ThemeOperationQueryBuilder Self => this;

        public ThemeOperationQueryBuilder() : this("theme")
        {
        }

        public ThemeOperationQueryBuilder(string name) : base(new Query<OnlineStoreTheme>(name))
        {
            Arguments = new ThemeArgumentsBuilder(base.InnerQuery);
        }

        public ThemeOperationQueryBuilder(IQuery<OnlineStoreTheme> query) : base(query)
        {
            Arguments = new ThemeArgumentsBuilder(base.InnerQuery);
        }

        public ThemeOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public ThemeOperationQueryBuilder Files(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileConnectionQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFileConnection>("files");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreThemeFileConnection>(query);
            return this;
        }

        public ThemeOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ThemeOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public ThemeOperationQueryBuilder Prefix()
        {
            base.InnerQuery.AddField("prefix");
            return this;
        }

        public ThemeOperationQueryBuilder Processing()
        {
            base.InnerQuery.AddField("processing");
            return this;
        }

        public ThemeOperationQueryBuilder ProcessingFailed()
        {
            base.InnerQuery.AddField("processingFailed");
            return this;
        }

        public ThemeOperationQueryBuilder Role()
        {
            base.InnerQuery.AddField("role");
            return this;
        }

        public ThemeOperationQueryBuilder ThemeStoreId()
        {
            base.InnerQuery.AddField("themeStoreId");
            return this;
        }

        public ThemeOperationQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public ThemeOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}