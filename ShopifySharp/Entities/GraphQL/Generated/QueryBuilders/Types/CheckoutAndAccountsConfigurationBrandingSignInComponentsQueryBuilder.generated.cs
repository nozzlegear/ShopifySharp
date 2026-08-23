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
    public sealed class CheckoutAndAccountsConfigurationBrandingSignInComponentsQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingSignInComponents, CheckoutAndAccountsConfigurationBrandingSignInComponentsQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingSignInComponentsQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingSignInComponentsQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingSignInComponents")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSignInComponentsQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingSignInComponents>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSignInComponentsQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingSignInComponents> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSignInComponentsQueryBuilder Header(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSignInHeaderQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingSignInHeader>("header");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSignInHeaderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingSignInHeader>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSignInComponentsQueryBuilder Main(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSignInMainQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingSignInMain>("main");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSignInMainQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingSignInMain>(query);
            return this;
        }
    }
}