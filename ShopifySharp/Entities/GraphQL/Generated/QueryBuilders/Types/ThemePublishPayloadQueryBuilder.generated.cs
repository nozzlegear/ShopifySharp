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
    public sealed class ThemePublishPayloadQueryBuilder : FieldsQueryBuilderBase<ThemePublishPayload, ThemePublishPayloadQueryBuilder>
    {
        protected override ThemePublishPayloadQueryBuilder Self => this;

        public ThemePublishPayloadQueryBuilder() : this("themePublishPayload")
        {
        }

        public ThemePublishPayloadQueryBuilder(string name) : base(new Query<ThemePublishPayload>(name))
        {
        }

        public ThemePublishPayloadQueryBuilder(IQuery<ThemePublishPayload> query) : base(query)
        {
        }

        public ThemePublishPayloadQueryBuilder Theme(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeQueryBuilder> build)
        {
            var query = new Query<OnlineStoreTheme>("theme");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OnlineStoreThemeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreTheme>(query);
            return this;
        }

        public ThemePublishPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ThemePublishUserErrorQueryBuilder> build)
        {
            var query = new Query<ThemePublishUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ThemePublishUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ThemePublishUserError>(query);
            return this;
        }
    }
}