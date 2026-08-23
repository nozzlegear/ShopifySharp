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
    public sealed class CheckoutAndAccountsConfigurationBrandingDesignTokensQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingDesignTokens, CheckoutAndAccountsConfigurationBrandingDesignTokensQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingDesignTokensQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingDesignTokensQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingDesignTokens")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingDesignTokensQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingDesignTokens>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingDesignTokensQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingDesignTokens> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingDesignTokensQueryBuilder Colors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingDesignTokenColorsQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingDesignTokenColors>("colors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingDesignTokenColorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingDesignTokenColors>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingDesignTokensQueryBuilder CornerRadius(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCornerRadiusVariablesQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingCornerRadiusVariables>("cornerRadius");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCornerRadiusVariablesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingCornerRadiusVariables>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingDesignTokensQueryBuilder Typography(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingTypographyQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingTypography>("typography");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingTypographyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingTypography>(query);
            return this;
        }
    }
}