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
    public sealed class CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeaderQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeader, CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeaderQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeaderQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeaderQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingCustomerAccountsHeader")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeaderQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeader>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeaderQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeader> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeaderQueryBuilder Alignment()
        {
            base.InnerQuery.AddField("alignment");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeaderQueryBuilder Colors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingColors>("colors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingColors>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeaderQueryBuilder Logo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCustomerAccountsLogoQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingCustomerAccountsLogo>("logo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCustomerAccountsLogoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingCustomerAccountsLogo>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeaderQueryBuilder Padding()
        {
            base.InnerQuery.AddField("padding");
            return this;
        }
    }
}