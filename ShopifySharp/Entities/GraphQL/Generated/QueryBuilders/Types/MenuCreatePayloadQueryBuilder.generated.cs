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
    public sealed class MenuCreatePayloadQueryBuilder : FieldsQueryBuilderBase<MenuCreatePayload, MenuCreatePayloadQueryBuilder>
    {
        protected override MenuCreatePayloadQueryBuilder Self => this;

        public MenuCreatePayloadQueryBuilder() : this("menuCreatePayload")
        {
        }

        public MenuCreatePayloadQueryBuilder(string name) : base(new Query<MenuCreatePayload>(name))
        {
        }

        public MenuCreatePayloadQueryBuilder(IQuery<MenuCreatePayload> query) : base(query)
        {
        }

        public MenuCreatePayloadQueryBuilder Menu(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuQueryBuilder> build)
        {
            var query = new Query<Menu>("menu");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Menu>(query);
            return this;
        }

        public MenuCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<MenuCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MenuCreateUserError>(query);
            return this;
        }
    }
}