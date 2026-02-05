#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class CheckoutBrandingOrderSummaryQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingOrderSummary, CheckoutBrandingOrderSummaryQueryBuilder>
    {
        protected override CheckoutBrandingOrderSummaryQueryBuilder Self => this;

        public CheckoutBrandingOrderSummaryQueryBuilder() : this("checkoutBrandingOrderSummary")
        {
        }

        public CheckoutBrandingOrderSummaryQueryBuilder(string name) : base(new Query<CheckoutBrandingOrderSummary>(name))
        {
        }

        public CheckoutBrandingOrderSummaryQueryBuilder(IQuery<CheckoutBrandingOrderSummary> query) : base(query)
        {
        }

        public CheckoutBrandingOrderSummaryQueryBuilder BackgroundImage(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingImageQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingImage>("backgroundImage");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingImage>(query);
            return this;
        }

        public CheckoutBrandingOrderSummaryQueryBuilder ColorScheme()
        {
            base.InnerQuery.AddField("colorScheme");
            return this;
        }

        public CheckoutBrandingOrderSummaryQueryBuilder Divider(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingContainerDividerQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingContainerDivider>("divider");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingContainerDividerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingContainerDivider>(query);
            return this;
        }

        public CheckoutBrandingOrderSummaryQueryBuilder Section(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingOrderSummarySectionQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingOrderSummarySection>("section");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingOrderSummarySectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingOrderSummarySection>(query);
            return this;
        }
    }
}