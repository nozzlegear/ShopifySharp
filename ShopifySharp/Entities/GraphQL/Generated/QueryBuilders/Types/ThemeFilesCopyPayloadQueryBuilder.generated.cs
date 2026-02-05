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
    public sealed class ThemeFilesCopyPayloadQueryBuilder : FieldsQueryBuilderBase<ThemeFilesCopyPayload, ThemeFilesCopyPayloadQueryBuilder>
    {
        protected override ThemeFilesCopyPayloadQueryBuilder Self => this;

        public ThemeFilesCopyPayloadQueryBuilder() : this("themeFilesCopyPayload")
        {
        }

        public ThemeFilesCopyPayloadQueryBuilder(string name) : base(new Query<ThemeFilesCopyPayload>(name))
        {
        }

        public ThemeFilesCopyPayloadQueryBuilder(IQuery<ThemeFilesCopyPayload> query) : base(query)
        {
        }

        public ThemeFilesCopyPayloadQueryBuilder CopiedThemeFiles(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeFileOperationResultQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFileOperationResult>("copiedThemeFiles");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeFileOperationResultQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreThemeFileOperationResult>(query);
            return this;
        }

        public ThemeFilesCopyPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeFilesUserErrorsQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFilesUserErrors>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeFilesUserErrorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreThemeFilesUserErrors>(query);
            return this;
        }
    }
}