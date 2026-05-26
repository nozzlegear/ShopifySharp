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
    public sealed class CheckoutAndAccountsConfigurationBrandingCustomerAccountsFooterQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingCustomerAccountsFooter, CheckoutAndAccountsConfigurationBrandingCustomerAccountsFooterQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingCustomerAccountsFooterQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsFooterQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingCustomerAccountsFooter")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsFooterQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingCustomerAccountsFooter>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsFooterQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingCustomerAccountsFooter> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsFooterQueryBuilder Alignment()
        {
            base.InnerQuery.AddField("alignment");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsFooterQueryBuilder Colors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingColors>("colors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingColors>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsFooterQueryBuilder Padding()
        {
            base.InnerQuery.AddField("padding");
            return this;
        }
    }
}