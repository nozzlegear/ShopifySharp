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
    public sealed class CheckoutAndAccountsConfigurationBrandingCustomFontGroupQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingCustomFontGroup, CheckoutAndAccountsConfigurationBrandingCustomFontGroupQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingCustomFontGroupQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingCustomFontGroupQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingCustomFontGroup")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomFontGroupQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingCustomFontGroup>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomFontGroupQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingCustomFontGroup> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomFontGroupQueryBuilder Base(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCustomFontQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingCustomFont>("base");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCustomFontQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingCustomFont>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomFontGroupQueryBuilder Bold(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCustomFontQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingCustomFont>("bold");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCustomFontQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingCustomFont>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomFontGroupQueryBuilder LoadingStrategy()
        {
            base.InnerQuery.AddField("loadingStrategy");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomFontGroupQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}