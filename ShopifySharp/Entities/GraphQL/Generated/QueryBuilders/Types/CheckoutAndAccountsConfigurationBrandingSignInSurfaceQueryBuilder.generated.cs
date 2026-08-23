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
    public sealed class CheckoutAndAccountsConfigurationBrandingSignInSurfaceQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingSignInSurface, CheckoutAndAccountsConfigurationBrandingSignInSurfaceQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingSignInSurfaceQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingSignInSurfaceQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingSignInSurface")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSignInSurfaceQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingSignInSurface>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSignInSurfaceQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingSignInSurface> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSignInSurfaceQueryBuilder Components(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSignInComponentsQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingSignInComponents>("components");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSignInComponentsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingSignInComponents>(query);
            return this;
        }
    }
}