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
    public sealed class CheckoutAndAccountsConfigurationBrandingBaseColorRolesQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingBaseColorRoles, CheckoutAndAccountsConfigurationBrandingBaseColorRolesQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingBaseColorRolesQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingBaseColorRolesQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingBaseColorRoles")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingBaseColorRolesQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingBaseColorRoles>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingBaseColorRolesQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingBaseColorRoles> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingBaseColorRolesQueryBuilder Accent()
        {
            base.InnerQuery.AddField("accent");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingBaseColorRolesQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingBaseColorRolesQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingBaseColorRolesQueryBuilder Decorative()
        {
            base.InnerQuery.AddField("decorative");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingBaseColorRolesQueryBuilder Icon()
        {
            base.InnerQuery.AddField("icon");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingBaseColorRolesQueryBuilder Text()
        {
            base.InnerQuery.AddField("text");
            return this;
        }
    }
}