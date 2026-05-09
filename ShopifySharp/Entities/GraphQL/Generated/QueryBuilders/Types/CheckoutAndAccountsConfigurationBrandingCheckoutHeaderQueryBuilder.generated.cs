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
    public sealed class CheckoutAndAccountsConfigurationBrandingCheckoutHeaderQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingCheckoutHeader, CheckoutAndAccountsConfigurationBrandingCheckoutHeaderQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingCheckoutHeaderQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingCheckoutHeaderQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingCheckoutHeader")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutHeaderQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingCheckoutHeader>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutHeaderQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingCheckoutHeader> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutHeaderQueryBuilder Alignment()
        {
            base.InnerQuery.AddField("alignment");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutHeaderQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutHeaderQueryBuilder CartLink(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingHeaderCartLinkQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingHeaderCartLink>("cartLink");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingHeaderCartLinkQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingHeaderCartLink>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutHeaderQueryBuilder Colors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingColors>("colors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingColors>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutHeaderQueryBuilder Divided()
        {
            base.InnerQuery.AddField("divided");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutHeaderQueryBuilder Logo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingLogoQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingLogo>("logo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingLogoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingLogo>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutHeaderQueryBuilder Padding()
        {
            base.InnerQuery.AddField("padding");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutHeaderQueryBuilder Position()
        {
            base.InnerQuery.AddField("position");
            return this;
        }
    }
}