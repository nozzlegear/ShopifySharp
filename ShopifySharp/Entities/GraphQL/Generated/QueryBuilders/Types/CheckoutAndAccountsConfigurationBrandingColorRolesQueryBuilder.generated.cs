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
    public sealed class CheckoutAndAccountsConfigurationBrandingColorRolesQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingColorRoles, CheckoutAndAccountsConfigurationBrandingColorRolesQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingColorRolesQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingColorRolesQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingColorRoles")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingColorRolesQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingColorRoles>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingColorRolesQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingColorRoles> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingColorRolesQueryBuilder Accent()
        {
            base.InnerQuery.AddField("accent");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingColorRolesQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingColorRolesQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingColorRolesQueryBuilder Decorative()
        {
            base.InnerQuery.AddField("decorative");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingColorRolesQueryBuilder Icon()
        {
            base.InnerQuery.AddField("icon");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingColorRolesQueryBuilder Text()
        {
            base.InnerQuery.AddField("text");
            return this;
        }
    }
}