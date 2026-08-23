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
    public sealed class CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingColors, CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingColors")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingColors>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingColors> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder Base(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingBaseColorRolesQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingBaseColorRoles>("base");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingBaseColorRolesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingBaseColorRoles>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder Control(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingControlColorRolesQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingControlColorRoles>("control");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingControlColorRolesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingControlColorRoles>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder PrimaryButton(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRolesQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRoles>("primaryButton");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRolesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingPrimaryButtonColorRoles>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder SecondaryButton(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRolesQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRoles>("secondaryButton");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRolesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingSecondaryButtonColorRoles>(query);
            return this;
        }
    }
}