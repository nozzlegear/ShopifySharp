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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class MenuUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<MenuUpdateUserError, MenuUpdateUserErrorQueryBuilder>
    {
        protected override MenuUpdateUserErrorQueryBuilder Self => this;

        public MenuUpdateUserErrorQueryBuilder() : this("menuUpdateUserError")
        {
        }

        public MenuUpdateUserErrorQueryBuilder(string name) : base(new Query<MenuUpdateUserError>(name))
        {
        }

        public MenuUpdateUserErrorQueryBuilder(IQuery<MenuUpdateUserError> query) : base(query)
        {
        }

        public MenuUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MenuUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public MenuUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}