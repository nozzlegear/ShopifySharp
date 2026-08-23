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
    public sealed class CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponentsQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponents, CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponentsQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponentsQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponentsQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingCustomerAccountsComponents")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponentsQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponents>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponentsQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponents> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponentsQueryBuilder Footer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCustomerAccountsFooterQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingCustomerAccountsFooter>("footer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCustomerAccountsFooterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingCustomerAccountsFooter>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponentsQueryBuilder Header(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeaderQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeader>("header");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeaderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeader>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponentsQueryBuilder Main(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingCustomerAccountsMain>("main");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingCustomerAccountsMain>(query);
            return this;
        }
    }
}