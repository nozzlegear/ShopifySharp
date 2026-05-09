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
    public sealed class CheckoutAndAccountsConfigurationBrandingShopifyFontGroupQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingShopifyFontGroup, CheckoutAndAccountsConfigurationBrandingShopifyFontGroupQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingShopifyFontGroupQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingShopifyFontGroupQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingShopifyFontGroup")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingShopifyFontGroupQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingShopifyFontGroup>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingShopifyFontGroupQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingShopifyFontGroup> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingShopifyFontGroupQueryBuilder Base(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingShopifyFontQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingShopifyFont>("base");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingShopifyFontQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingShopifyFont>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingShopifyFontGroupQueryBuilder Bold(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingShopifyFontQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingShopifyFont>("bold");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingShopifyFontQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingShopifyFont>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingShopifyFontGroupQueryBuilder LoadingStrategy()
        {
            base.InnerQuery.AddField("loadingStrategy");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingShopifyFontGroupQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}