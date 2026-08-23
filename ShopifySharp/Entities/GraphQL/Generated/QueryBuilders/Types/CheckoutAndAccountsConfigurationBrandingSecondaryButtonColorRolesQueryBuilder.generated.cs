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
    public sealed class CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRolesQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRoles, CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRolesQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRolesQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRolesQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingSecondaryButtonColorRoles")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRolesQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRoles>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRolesQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRoles> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRolesQueryBuilder Accent()
        {
            base.InnerQuery.AddField("accent");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRolesQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRolesQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRolesQueryBuilder Decorative()
        {
            base.InnerQuery.AddField("decorative");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRolesQueryBuilder Hover(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorRolesQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingColorRoles>("hover");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorRolesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingColorRoles>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRolesQueryBuilder Icon()
        {
            base.InnerQuery.AddField("icon");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRolesQueryBuilder Text()
        {
            base.InnerQuery.AddField("text");
            return this;
        }
    }
}