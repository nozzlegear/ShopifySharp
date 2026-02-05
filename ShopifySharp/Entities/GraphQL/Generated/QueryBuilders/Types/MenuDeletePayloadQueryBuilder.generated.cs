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
    public sealed class MenuDeletePayloadQueryBuilder : FieldsQueryBuilderBase<MenuDeletePayload, MenuDeletePayloadQueryBuilder>
    {
        protected override MenuDeletePayloadQueryBuilder Self => this;

        public MenuDeletePayloadQueryBuilder() : this("menuDeletePayload")
        {
        }

        public MenuDeletePayloadQueryBuilder(string name) : base(new Query<MenuDeletePayload>(name))
        {
        }

        public MenuDeletePayloadQueryBuilder(IQuery<MenuDeletePayload> query) : base(query)
        {
        }

        public MenuDeletePayloadQueryBuilder DeletedMenuId()
        {
            base.InnerQuery.AddField("deletedMenuId");
            return this;
        }

        public MenuDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<MenuDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MenuDeleteUserError>(query);
            return this;
        }
    }
}