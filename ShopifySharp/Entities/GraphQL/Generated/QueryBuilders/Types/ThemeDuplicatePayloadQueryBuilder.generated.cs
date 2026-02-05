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
    public sealed class ThemeDuplicatePayloadQueryBuilder : FieldsQueryBuilderBase<ThemeDuplicatePayload, ThemeDuplicatePayloadQueryBuilder>
    {
        protected override ThemeDuplicatePayloadQueryBuilder Self => this;

        public ThemeDuplicatePayloadQueryBuilder() : this("themeDuplicatePayload")
        {
        }

        public ThemeDuplicatePayloadQueryBuilder(string name) : base(new Query<ThemeDuplicatePayload>(name))
        {
        }

        public ThemeDuplicatePayloadQueryBuilder(IQuery<ThemeDuplicatePayload> query) : base(query)
        {
        }

        public ThemeDuplicatePayloadQueryBuilder NewTheme(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeQueryBuilder> build)
        {
            var query = new Query<OnlineStoreTheme>("newTheme");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreTheme>(query);
            return this;
        }

        public ThemeDuplicatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ThemeDuplicateUserErrorQueryBuilder> build)
        {
            var query = new Query<ThemeDuplicateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ThemeDuplicateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ThemeDuplicateUserError>(query);
            return this;
        }
    }
}