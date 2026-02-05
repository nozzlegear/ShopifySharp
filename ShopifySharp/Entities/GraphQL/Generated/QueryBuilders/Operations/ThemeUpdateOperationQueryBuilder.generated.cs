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
    public sealed class ThemeUpdateOperationQueryBuilder : FieldsQueryBuilderBase<ThemeUpdatePayload, ThemeUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<ThemeUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ThemeUpdateArgumentsBuilder Arguments { get; }
        protected override ThemeUpdateOperationQueryBuilder Self => this;

        public ThemeUpdateOperationQueryBuilder() : this("themeUpdate")
        {
        }

        public ThemeUpdateOperationQueryBuilder(string name) : base(new Query<ThemeUpdatePayload>(name))
        {
            Arguments = new ThemeUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ThemeUpdateOperationQueryBuilder(IQuery<ThemeUpdatePayload> query) : base(query)
        {
            Arguments = new ThemeUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ThemeUpdateOperationQueryBuilder Theme(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeQueryBuilder> build)
        {
            var query = new Query<OnlineStoreTheme>("theme");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreTheme>(query);
            return this;
        }

        public ThemeUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ThemeUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<ThemeUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ThemeUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ThemeUpdateUserError>(query);
            return this;
        }
    }
}