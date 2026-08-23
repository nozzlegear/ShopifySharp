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
    public sealed class CheckoutAndAccountsConfigurationBrandingCustomerAccountsSurfaceQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingCustomerAccountsSurface, CheckoutAndAccountsConfigurationBrandingCustomerAccountsSurfaceQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingCustomerAccountsSurfaceQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsSurfaceQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingCustomerAccountsSurface")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsSurfaceQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingCustomerAccountsSurface>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsSurfaceQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingCustomerAccountsSurface> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCustomerAccountsSurfaceQueryBuilder Components(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponentsQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponents>("components");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponentsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponents>(query);
            return this;
        }
    }
}