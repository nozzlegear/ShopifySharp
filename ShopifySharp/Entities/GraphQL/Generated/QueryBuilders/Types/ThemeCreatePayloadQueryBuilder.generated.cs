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
    public sealed class ThemeCreatePayloadQueryBuilder : FieldsQueryBuilderBase<ThemeCreatePayload, ThemeCreatePayloadQueryBuilder>
    {
        protected override ThemeCreatePayloadQueryBuilder Self => this;

        public ThemeCreatePayloadQueryBuilder() : this("themeCreatePayload")
        {
        }

        public ThemeCreatePayloadQueryBuilder(string name) : base(new Query<ThemeCreatePayload>(name))
        {
        }

        public ThemeCreatePayloadQueryBuilder(IQuery<ThemeCreatePayload> query) : base(query)
        {
        }

        public ThemeCreatePayloadQueryBuilder Theme(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeQueryBuilder> build)
        {
            var query = new Query<OnlineStoreTheme>("theme");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreTheme>(query);
            return this;
        }

        public ThemeCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ThemeCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<ThemeCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ThemeCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ThemeCreateUserError>(query);
            return this;
        }
    }
}