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
    public sealed class ThemeFilesDeleteOperationQueryBuilder : FieldsQueryBuilderBase<ThemeFilesDeletePayload, ThemeFilesDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<ThemeFilesDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ThemeFilesDeleteArgumentsBuilder Arguments { get; }
        protected override ThemeFilesDeleteOperationQueryBuilder Self => this;

        public ThemeFilesDeleteOperationQueryBuilder() : this("themeFilesDelete")
        {
        }

        public ThemeFilesDeleteOperationQueryBuilder(string name) : base(new Query<ThemeFilesDeletePayload>(name))
        {
            Arguments = new ThemeFilesDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ThemeFilesDeleteOperationQueryBuilder(IQuery<ThemeFilesDeletePayload> query) : base(query)
        {
            Arguments = new ThemeFilesDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ThemeFilesDeleteOperationQueryBuilder DeletedThemeFiles(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileOperationResultQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFileOperationResult>("deletedThemeFiles");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFileOperationResultQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreThemeFileOperationResult>(query);
            return this;
        }

        public ThemeFilesDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFilesUserErrorsQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFilesUserErrors>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeFilesUserErrorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreThemeFilesUserErrors>(query);
            return this;
        }
    }
}