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
    public sealed class CheckoutAndAccountsConfigurationBrandingSurfacesQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingSurfaces, CheckoutAndAccountsConfigurationBrandingSurfacesQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingSurfacesQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingSurfacesQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingSurfaces")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSurfacesQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingSurfaces>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSurfacesQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingSurfaces> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSurfacesQueryBuilder Checkout(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCheckoutSurfaceQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingCheckoutSurface>("checkout");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCheckoutSurfaceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingCheckoutSurface>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSurfacesQueryBuilder CustomerAccounts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCustomerAccountsSurfaceQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingCustomerAccountsSurface>("customerAccounts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCustomerAccountsSurfaceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingCustomerAccountsSurface>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSurfacesQueryBuilder SignIn(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSignInSurfaceQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingSignInSurface>("signIn");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSignInSurfaceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingSignInSurface>(query);
            return this;
        }
    }
}