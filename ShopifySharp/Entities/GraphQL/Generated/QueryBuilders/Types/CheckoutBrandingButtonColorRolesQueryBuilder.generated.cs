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
    public sealed class CheckoutBrandingButtonColorRolesQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingButtonColorRoles, CheckoutBrandingButtonColorRolesQueryBuilder>
    {
        protected override CheckoutBrandingButtonColorRolesQueryBuilder Self => this;

        public CheckoutBrandingButtonColorRolesQueryBuilder() : this("checkoutBrandingButtonColorRoles")
        {
        }

        public CheckoutBrandingButtonColorRolesQueryBuilder(string name) : base(new Query<CheckoutBrandingButtonColorRoles>(name))
        {
        }

        public CheckoutBrandingButtonColorRolesQueryBuilder(IQuery<CheckoutBrandingButtonColorRoles> query) : base(query)
        {
        }

        public CheckoutBrandingButtonColorRolesQueryBuilder Accent()
        {
            base.InnerQuery.AddField("accent");
            return this;
        }

        public CheckoutBrandingButtonColorRolesQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }

        public CheckoutBrandingButtonColorRolesQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutBrandingButtonColorRolesQueryBuilder Decorative()
        {
            base.InnerQuery.AddField("decorative");
            return this;
        }

        public CheckoutBrandingButtonColorRolesQueryBuilder Hover(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingColorRolesQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingColorRoles>("hover");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingColorRolesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingColorRoles>(query);
            return this;
        }

        public CheckoutBrandingButtonColorRolesQueryBuilder Icon()
        {
            base.InnerQuery.AddField("icon");
            return this;
        }

        public CheckoutBrandingButtonColorRolesQueryBuilder Text()
        {
            base.InnerQuery.AddField("text");
            return this;
        }
    }
}