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
    public sealed class CheckoutAndAccountsConfigurationBrandingExpressCheckoutQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingExpressCheckout, CheckoutAndAccountsConfigurationBrandingExpressCheckoutQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingExpressCheckoutQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingExpressCheckoutQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingExpressCheckout")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingExpressCheckoutQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingExpressCheckout>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingExpressCheckoutQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingExpressCheckout> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingExpressCheckoutQueryBuilder Button(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingExpressCheckoutButtonQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingExpressCheckoutButton>("button");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingExpressCheckoutButtonQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingExpressCheckoutButton>(query);
            return this;
        }
    }
}