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
    public sealed class CheckoutAndAccountsConfigurationBrandingExpressCheckoutButtonQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingExpressCheckoutButton, CheckoutAndAccountsConfigurationBrandingExpressCheckoutButtonQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingExpressCheckoutButtonQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingExpressCheckoutButtonQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingExpressCheckoutButton")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingExpressCheckoutButtonQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingExpressCheckoutButton>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingExpressCheckoutButtonQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingExpressCheckoutButton> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingExpressCheckoutButtonQueryBuilder CornerRadius()
        {
            base.InnerQuery.AddField("cornerRadius");
            return this;
        }
    }
}