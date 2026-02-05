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
    public sealed class ThemeFilesUpsertOperationQueryBuilder : FieldsQueryBuilderBase<ThemeFilesUpsertPayload, ThemeFilesUpsertOperationQueryBuilder>, IGraphOperationQueryBuilder<ThemeFilesUpsertPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ThemeFilesUpsertArgumentsBuilder Arguments { get; }
        protected override ThemeFilesUpsertOperationQueryBuilder Self => this;

        public ThemeFilesUpsertOperationQueryBuilder() : this("themeFilesUpsert")
        {
        }

        public ThemeFilesUpsertOperationQueryBuilder(string name) : base(new Query<ThemeFilesUpsertPayload>(name))
        {
            Arguments = new ThemeFilesUpsertArgumentsBuilder(base.InnerQuery);
        }

        public ThemeFilesUpsertOperationQueryBuilder(IQuery<ThemeFilesUpsertPayload> query) : base(query)
        {
            Arguments = new ThemeFilesUpsertArgumentsBuilder(base.InnerQuery);
        }

        public ThemeFilesUpsertOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public ThemeFilesUpsertOperationQueryBuilder UpsertedThemeFiles(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeFileOperationResultQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFileOperationResult>("upsertedThemeFiles");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeFileOperationResultQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreThemeFileOperationResult>(query);
            return this;
        }

        public ThemeFilesUpsertOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeFilesUserErrorsQueryBuilder> build)
        {
            var query = new Query<OnlineStoreThemeFilesUserErrors>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeFilesUserErrorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreThemeFilesUserErrors>(query);
            return this;
        }
    }
}