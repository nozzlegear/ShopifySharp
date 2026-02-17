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
    public sealed class ThemeFilesCopyOperationQueryBuilder : FieldsQueryBuilderBase<ThemeFilesCopyPayload, ThemeFilesCopyOperationQueryBuilder>, IGraphOperationQueryBuilder<ThemeFilesCopyPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ThemeFilesCopyArgumentsBuilder Arguments { get; }
        protected override ThemeFilesCopyOperationQueryBuilder Self => this;

        public ThemeFilesCopyOperationQueryBuilder() : this("themeFilesCopy")
        {
        }

        public ThemeFilesCopyOperationQueryBuilder(string name) : base(new Query<ThemeFilesCopyPayload>(name))
        {
            Arguments = new ThemeFilesCopyArgumentsBuilder(base.InnerQuery);
        }

        public ThemeFilesCopyOperationQueryBuilder(IQuery<ThemeFilesCopyPayload> query) : base(query)
        {
            Arguments = new ThemeFilesCopyArgumentsBuilder(base.InnerQuery);
        }

        public ThemeFilesCopyOperationQueryBuilder CopiedThemeFiles(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileOperationResultQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFileOperationResult>("copiedThemeFiles");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileOperationResultQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreThemeFileOperationResult>(query);
            return this;
        }

        public ThemeFilesCopyOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFilesUserErrorsQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFilesUserErrors>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFilesUserErrorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreThemeFilesUserErrors>(query);
            return this;
        }
    }
}