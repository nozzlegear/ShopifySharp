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
    public sealed class CheckoutAndAccountsConfigurationBrandingOrderSummarySectionQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingOrderSummarySection, CheckoutAndAccountsConfigurationBrandingOrderSummarySectionQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingOrderSummarySectionQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingOrderSummarySectionQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingOrderSummarySection")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingOrderSummarySectionQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingOrderSummarySection>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingOrderSummarySectionQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingOrderSummarySection> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingOrderSummarySectionQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingOrderSummarySectionQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingOrderSummarySectionQueryBuilder BorderStyle()
        {
            base.InnerQuery.AddField("borderStyle");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingOrderSummarySectionQueryBuilder BorderWidth()
        {
            base.InnerQuery.AddField("borderWidth");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingOrderSummarySectionQueryBuilder Colors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingColors>("colors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingColors>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingOrderSummarySectionQueryBuilder CornerRadius()
        {
            base.InnerQuery.AddField("cornerRadius");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingOrderSummarySectionQueryBuilder Padding()
        {
            base.InnerQuery.AddField("padding");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingOrderSummarySectionQueryBuilder Shadow()
        {
            base.InnerQuery.AddField("shadow");
            return this;
        }
    }
}