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
    public sealed class CheckoutAndAccountsConfigurationBrandingDesignTokenColorsQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingDesignTokenColors, CheckoutAndAccountsConfigurationBrandingDesignTokenColorsQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingDesignTokenColorsQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingDesignTokenColorsQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingDesignTokenColors")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingDesignTokenColorsQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingDesignTokenColors>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingDesignTokenColorsQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingDesignTokenColors> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingDesignTokenColorsQueryBuilder Palette(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingPalette>("palette");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingPaletteQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingPalette>(query);
            return this;
        }
    }
}