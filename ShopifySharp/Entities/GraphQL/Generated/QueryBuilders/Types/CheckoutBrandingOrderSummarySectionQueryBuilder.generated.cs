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
    public sealed class CheckoutBrandingOrderSummarySectionQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingOrderSummarySection, CheckoutBrandingOrderSummarySectionQueryBuilder>
    {
        protected override CheckoutBrandingOrderSummarySectionQueryBuilder Self => this;

        public CheckoutBrandingOrderSummarySectionQueryBuilder() : this("checkoutBrandingOrderSummarySection")
        {
        }

        public CheckoutBrandingOrderSummarySectionQueryBuilder(string name) : base(new Query<CheckoutBrandingOrderSummarySection>(name))
        {
        }

        public CheckoutBrandingOrderSummarySectionQueryBuilder(IQuery<CheckoutBrandingOrderSummarySection> query) : base(query)
        {
        }

        public CheckoutBrandingOrderSummarySectionQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }

        public CheckoutBrandingOrderSummarySectionQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutBrandingOrderSummarySectionQueryBuilder BorderStyle()
        {
            base.InnerQuery.AddField("borderStyle");
            return this;
        }

        public CheckoutBrandingOrderSummarySectionQueryBuilder BorderWidth()
        {
            base.InnerQuery.AddField("borderWidth");
            return this;
        }

        public CheckoutBrandingOrderSummarySectionQueryBuilder ColorScheme()
        {
            base.InnerQuery.AddField("colorScheme");
            return this;
        }

        public CheckoutBrandingOrderSummarySectionQueryBuilder CornerRadius()
        {
            base.InnerQuery.AddField("cornerRadius");
            return this;
        }

        public CheckoutBrandingOrderSummarySectionQueryBuilder Padding()
        {
            base.InnerQuery.AddField("padding");
            return this;
        }

        public CheckoutBrandingOrderSummarySectionQueryBuilder Shadow()
        {
            base.InnerQuery.AddField("shadow");
            return this;
        }
    }
}