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
    public sealed class CheckoutAndAccountsConfigurationBrandingOrderSummaryQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingOrderSummary, CheckoutAndAccountsConfigurationBrandingOrderSummaryQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingOrderSummaryQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingOrderSummaryQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingOrderSummary")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingOrderSummaryQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingOrderSummary>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingOrderSummaryQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingOrderSummary> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingOrderSummaryQueryBuilder Colors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingColors>("colors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingColors>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingOrderSummaryQueryBuilder Divider(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingContainerDividerQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingContainerDivider>("divider");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingContainerDividerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingContainerDivider>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingOrderSummaryQueryBuilder Section(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingOrderSummarySectionQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingOrderSummarySection>("section");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingOrderSummarySectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingOrderSummarySection>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingOrderSummaryQueryBuilder BackgroundImage(Action<CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingImageValue>("backgroundImage");
            var unionBuilder = new CheckoutAndAccountsConfigurationBrandingImageValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}