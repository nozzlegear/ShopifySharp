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
    public sealed class MenuCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<MenuCreateUserError, MenuCreateUserErrorQueryBuilder>
    {
        protected override MenuCreateUserErrorQueryBuilder Self => this;

        public MenuCreateUserErrorQueryBuilder() : this("menuCreateUserError")
        {
        }

        public MenuCreateUserErrorQueryBuilder(string name) : base(new Query<MenuCreateUserError>(name))
        {
        }

        public MenuCreateUserErrorQueryBuilder(IQuery<MenuCreateUserError> query) : base(query)
        {
        }

        public MenuCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MenuCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public MenuCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}