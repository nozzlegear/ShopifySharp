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
    public sealed class CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRolesQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRoles, CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRolesQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRolesQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRolesQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingPrimaryButtonColorRoles")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRolesQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRoles>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRolesQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRoles> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRolesQueryBuilder Accent()
        {
            base.InnerQuery.AddField("accent");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRolesQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRolesQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRolesQueryBuilder Decorative()
        {
            base.InnerQuery.AddField("decorative");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRolesQueryBuilder Hover(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorRolesQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingColorRoles>("hover");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorRolesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingColorRoles>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRolesQueryBuilder Icon()
        {
            base.InnerQuery.AddField("icon");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRolesQueryBuilder Text()
        {
            base.InnerQuery.AddField("text");
            return this;
        }
    }
}