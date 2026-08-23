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
    public sealed class CheckoutAndAccountsConfigurationBrandingQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBranding, CheckoutAndAccountsConfigurationBrandingQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingQueryBuilder() : this("checkoutAndAccountsConfigurationBranding")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBranding>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBranding> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingQueryBuilder Components(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingComponents>("components");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingComponentsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingComponents>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingQueryBuilder DesignTokens(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingDesignTokensQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingDesignTokens>("designTokens");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingDesignTokensQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingDesignTokens>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingQueryBuilder Surfaces(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSurfacesQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingSurfaces>("surfaces");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSurfacesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingSurfaces>(query);
            return this;
        }
    }
}