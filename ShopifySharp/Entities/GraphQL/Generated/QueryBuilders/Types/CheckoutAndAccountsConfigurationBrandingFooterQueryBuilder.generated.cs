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
    public sealed class CheckoutAndAccountsConfigurationBrandingFooterQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingFooter, CheckoutAndAccountsConfigurationBrandingFooterQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingFooterQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingFooterQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingFooter")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingFooterQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingFooter>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingFooterQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingFooter> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingFooterQueryBuilder Alignment()
        {
            base.InnerQuery.AddField("alignment");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingFooterQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingFooterQueryBuilder Colors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingColors>("colors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingColors>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingFooterQueryBuilder Content(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingFooterContentQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingFooterContent>("content");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingFooterContentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingFooterContent>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingFooterQueryBuilder Divided()
        {
            base.InnerQuery.AddField("divided");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingFooterQueryBuilder Padding()
        {
            base.InnerQuery.AddField("padding");
            return this;
        }
    }
}