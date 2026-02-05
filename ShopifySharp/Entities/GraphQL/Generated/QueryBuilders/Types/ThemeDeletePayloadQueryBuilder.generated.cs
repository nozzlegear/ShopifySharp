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
    public sealed class ThemeDeletePayloadQueryBuilder : FieldsQueryBuilderBase<ThemeDeletePayload, ThemeDeletePayloadQueryBuilder>
    {
        protected override ThemeDeletePayloadQueryBuilder Self => this;

        public ThemeDeletePayloadQueryBuilder() : this("themeDeletePayload")
        {
        }

        public ThemeDeletePayloadQueryBuilder(string name) : base(new Query<ThemeDeletePayload>(name))
        {
        }

        public ThemeDeletePayloadQueryBuilder(IQuery<ThemeDeletePayload> query) : base(query)
        {
        }

        public ThemeDeletePayloadQueryBuilder DeletedThemeId()
        {
            base.InnerQuery.AddField("deletedThemeId");
            return this;
        }

        public ThemeDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ThemeDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<ThemeDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ThemeDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ThemeDeleteUserError>(query);
            return this;
        }
    }
}