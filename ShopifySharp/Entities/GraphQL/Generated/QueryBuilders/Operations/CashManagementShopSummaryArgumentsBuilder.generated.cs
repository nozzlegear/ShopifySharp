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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CashManagementShopSummaryArgumentsBuilder : ArgumentsBuilderBase<CashManagementSummary, CashManagementShopSummaryArgumentsBuilder>
    {
        protected override CashManagementShopSummaryArgumentsBuilder Self => this;

        public CashManagementShopSummaryArgumentsBuilder(IQuery<CashManagementSummary> query) : base(query)
        {
        }

        public CashManagementShopSummaryArgumentsBuilder CurrencyCode(CurrencyCode? currencyCode)
        {
            base.InnerQuery.AddArgument("currencyCode", currencyCode);
            return this;
        }

        public CashManagementShopSummaryArgumentsBuilder EndDate(DateOnly? endDate)
        {
            base.InnerQuery.AddArgument("endDate", endDate);
            return this;
        }

        public CashManagementShopSummaryArgumentsBuilder StartDate(DateOnly? startDate)
        {
            base.InnerQuery.AddArgument("startDate", startDate);
            return this;
        }
    }
}