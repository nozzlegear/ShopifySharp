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
    public sealed class ThemeDuplicateOperationQueryBuilder : FieldsQueryBuilderBase<ThemeDuplicatePayload, ThemeDuplicateOperationQueryBuilder>, IGraphOperationQueryBuilder<ThemeDuplicatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ThemeDuplicateArgumentsBuilder Arguments { get; }
        protected override ThemeDuplicateOperationQueryBuilder Self => this;

        public ThemeDuplicateOperationQueryBuilder() : this("themeDuplicate")
        {
        }

        public ThemeDuplicateOperationQueryBuilder(string name) : base(new Query<ThemeDuplicatePayload>(name))
        {
            Arguments = new ThemeDuplicateArgumentsBuilder(base.InnerQuery);
        }

        public ThemeDuplicateOperationQueryBuilder(IQuery<ThemeDuplicatePayload> query) : base(query)
        {
            Arguments = new ThemeDuplicateArgumentsBuilder(base.InnerQuery);
        }

        public ThemeDuplicateOperationQueryBuilder NewTheme(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeQueryBuilder> build)
        {
            var query = new Query<OnlineStoreTheme>("newTheme");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreTheme>(query);
            return this;
        }

        public ThemeDuplicateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ThemeDuplicateUserErrorQueryBuilder> build)
        {
            var query = new Query<ThemeDuplicateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ThemeDuplicateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ThemeDuplicateUserError>(query);
            return this;
        }
    }
}