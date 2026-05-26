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
    public sealed class CheckoutAndAccountsConfigurationBrandingCheckoutSurfaceQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingCheckoutSurface, CheckoutAndAccountsConfigurationBrandingCheckoutSurfaceQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingCheckoutSurfaceQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingCheckoutSurfaceQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingCheckoutSurface")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutSurfaceQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingCheckoutSurface>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutSurfaceQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingCheckoutSurface> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutSurfaceQueryBuilder Components(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCheckoutComponentsQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingCheckoutComponents>("components");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingCheckoutComponentsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingCheckoutComponents>(query);
            return this;
        }
    }
}