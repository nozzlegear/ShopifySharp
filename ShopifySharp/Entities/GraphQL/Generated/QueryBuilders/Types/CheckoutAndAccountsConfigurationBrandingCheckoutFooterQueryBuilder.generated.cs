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
    public sealed class CheckoutAndAccountsConfigurationBrandingCheckoutFooterQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingCheckoutFooter, CheckoutAndAccountsConfigurationBrandingCheckoutFooterQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingCheckoutFooterQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingCheckoutFooterQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingCheckoutFooter")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutFooterQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingCheckoutFooter>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutFooterQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingCheckoutFooter> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutFooterQueryBuilder Alignment()
        {
            base.InnerQuery.AddField("alignment");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutFooterQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutFooterQueryBuilder Colors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingColors>("colors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingColors>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutFooterQueryBuilder Content(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingFooterContentQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingFooterContent>("content");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingFooterContentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingFooterContent>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutFooterQueryBuilder Divided()
        {
            base.InnerQuery.AddField("divided");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutFooterQueryBuilder Padding()
        {
            base.InnerQuery.AddField("padding");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingCheckoutFooterQueryBuilder Position()
        {
            base.InnerQuery.AddField("position");
            return this;
        }
    }
}