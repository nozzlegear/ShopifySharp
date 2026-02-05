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
    public sealed class CheckoutBrandingColorRolesQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingColorRoles, CheckoutBrandingColorRolesQueryBuilder>
    {
        protected override CheckoutBrandingColorRolesQueryBuilder Self => this;

        public CheckoutBrandingColorRolesQueryBuilder() : this("checkoutBrandingColorRoles")
        {
        }

        public CheckoutBrandingColorRolesQueryBuilder(string name) : base(new Query<CheckoutBrandingColorRoles>(name))
        {
        }

        public CheckoutBrandingColorRolesQueryBuilder(IQuery<CheckoutBrandingColorRoles> query) : base(query)
        {
        }

        public CheckoutBrandingColorRolesQueryBuilder Accent()
        {
            base.InnerQuery.AddField("accent");
            return this;
        }

        public CheckoutBrandingColorRolesQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }

        public CheckoutBrandingColorRolesQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutBrandingColorRolesQueryBuilder Decorative()
        {
            base.InnerQuery.AddField("decorative");
            return this;
        }

        public CheckoutBrandingColorRolesQueryBuilder Icon()
        {
            base.InnerQuery.AddField("icon");
            return this;
        }

        public CheckoutBrandingColorRolesQueryBuilder Text()
        {
            base.InnerQuery.AddField("text");
            return this;
        }
    }
}