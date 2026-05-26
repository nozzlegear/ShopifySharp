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
    public sealed class CheckoutAndAccountsConfigurationBrandingMainQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingMain, CheckoutAndAccountsConfigurationBrandingMainQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingMainQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingMainQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingMain")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingMainQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingMain>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingMainQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingMain> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingMainQueryBuilder Colors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingColors>("colors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingColors>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingMainQueryBuilder Divider(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingContainerDividerQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingContainerDivider>("divider");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingContainerDividerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingContainerDivider>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingMainQueryBuilder Section(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingMainSectionQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingMainSection>("section");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingMainSectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingMainSection>(query);
            return this;
        }
    }
}