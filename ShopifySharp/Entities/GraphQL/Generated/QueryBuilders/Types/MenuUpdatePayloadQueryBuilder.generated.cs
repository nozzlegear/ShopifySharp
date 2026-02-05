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
    public sealed class MenuUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<MenuUpdatePayload, MenuUpdatePayloadQueryBuilder>
    {
        protected override MenuUpdatePayloadQueryBuilder Self => this;

        public MenuUpdatePayloadQueryBuilder() : this("menuUpdatePayload")
        {
        }

        public MenuUpdatePayloadQueryBuilder(string name) : base(new Query<MenuUpdatePayload>(name))
        {
        }

        public MenuUpdatePayloadQueryBuilder(IQuery<MenuUpdatePayload> query) : base(query)
        {
        }

        public MenuUpdatePayloadQueryBuilder Menu(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuQueryBuilder> build)
        {
            var query = new Query<Menu>("menu");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Menu>(query);
            return this;
        }

        public MenuUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<MenuUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MenuUpdateUserError>(query);
            return this;
        }
    }
}