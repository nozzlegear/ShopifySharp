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
    public sealed class CheckoutAndAccountsConfigurationBrandingHeaderQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingHeader, CheckoutAndAccountsConfigurationBrandingHeaderQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingHeaderQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingHeaderQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingHeader")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingHeaderQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingHeader>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingHeaderQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingHeader> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingHeaderQueryBuilder Alignment()
        {
            base.InnerQuery.AddField("alignment");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingHeaderQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingHeaderQueryBuilder Colors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingColors>("colors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingColors>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingHeaderQueryBuilder Divided()
        {
            base.InnerQuery.AddField("divided");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingHeaderQueryBuilder Logo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingLogoQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingLogo>("logo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingLogoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingLogo>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingHeaderQueryBuilder Padding()
        {
            base.InnerQuery.AddField("padding");
            return this;
        }
    }
}