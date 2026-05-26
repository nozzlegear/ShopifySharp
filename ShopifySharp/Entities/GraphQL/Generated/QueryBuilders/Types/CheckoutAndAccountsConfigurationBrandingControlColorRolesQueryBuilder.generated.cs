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
    public sealed class CheckoutAndAccountsConfigurationBrandingControlColorRolesQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingControlColorRoles, CheckoutAndAccountsConfigurationBrandingControlColorRolesQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingControlColorRolesQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingControlColorRolesQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingControlColorRoles")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingControlColorRolesQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingControlColorRoles>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingControlColorRolesQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingControlColorRoles> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingControlColorRolesQueryBuilder Accent()
        {
            base.InnerQuery.AddField("accent");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingControlColorRolesQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingControlColorRolesQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingControlColorRolesQueryBuilder Decorative()
        {
            base.InnerQuery.AddField("decorative");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingControlColorRolesQueryBuilder Icon()
        {
            base.InnerQuery.AddField("icon");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingControlColorRolesQueryBuilder Selected(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorRolesQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingColorRoles>("selected");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorRolesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingColorRoles>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingControlColorRolesQueryBuilder Text()
        {
            base.InnerQuery.AddField("text");
            return this;
        }
    }
}