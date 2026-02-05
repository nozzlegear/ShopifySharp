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
    public sealed class ThemeDeleteOperationQueryBuilder : FieldsQueryBuilderBase<ThemeDeletePayload, ThemeDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<ThemeDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ThemeDeleteArgumentsBuilder Arguments { get; }
        protected override ThemeDeleteOperationQueryBuilder Self => this;

        public ThemeDeleteOperationQueryBuilder() : this("themeDelete")
        {
        }

        public ThemeDeleteOperationQueryBuilder(string name) : base(new Query<ThemeDeletePayload>(name))
        {
            Arguments = new ThemeDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ThemeDeleteOperationQueryBuilder(IQuery<ThemeDeletePayload> query) : base(query)
        {
            Arguments = new ThemeDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ThemeDeleteOperationQueryBuilder DeletedThemeId()
        {
            base.InnerQuery.AddField("deletedThemeId");
            return this;
        }

        public ThemeDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ThemeDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<ThemeDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ThemeDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ThemeDeleteUserError>(query);
            return this;
        }
    }
}