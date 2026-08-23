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
    public sealed class CheckoutAndAccountsConfigurationBrandingSignInHeaderQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingSignInHeader, CheckoutAndAccountsConfigurationBrandingSignInHeaderQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingSignInHeaderQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingSignInHeaderQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingSignInHeader")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSignInHeaderQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingSignInHeader>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSignInHeaderQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingSignInHeader> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSignInHeaderQueryBuilder Logo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSignInLogoQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingSignInLogo>("logo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingSignInLogoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingSignInLogo>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSignInHeaderQueryBuilder Padding()
        {
            base.InnerQuery.AddField("padding");
            return this;
        }
    }
}