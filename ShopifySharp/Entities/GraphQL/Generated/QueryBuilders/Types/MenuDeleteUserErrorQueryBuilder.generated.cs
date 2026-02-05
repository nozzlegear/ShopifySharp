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
    public sealed class MenuDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<MenuDeleteUserError, MenuDeleteUserErrorQueryBuilder>
    {
        protected override MenuDeleteUserErrorQueryBuilder Self => this;

        public MenuDeleteUserErrorQueryBuilder() : this("menuDeleteUserError")
        {
        }

        public MenuDeleteUserErrorQueryBuilder(string name) : base(new Query<MenuDeleteUserError>(name))
        {
        }

        public MenuDeleteUserErrorQueryBuilder(IQuery<MenuDeleteUserError> query) : base(query)
        {
        }

        public MenuDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MenuDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public MenuDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}