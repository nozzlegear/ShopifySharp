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
    public sealed class QueryRootCashManagementShopSummaryArgumentsBuilder : ArgumentsBuilderBase<CashManagementSummary?, QueryRootCashManagementShopSummaryArgumentsBuilder>
    {
        protected override QueryRootCashManagementShopSummaryArgumentsBuilder Self => this;

        public QueryRootCashManagementShopSummaryArgumentsBuilder(IQuery<CashManagementSummary?> query) : base(query)
        {
        }

        public QueryRootCashManagementShopSummaryArgumentsBuilder CurrencyCode(CurrencyCode? currencyCode)
        {
            base.InnerQuery.AddArgument("currencyCode", currencyCode);
            return this;
        }

        public QueryRootCashManagementShopSummaryArgumentsBuilder EndDate(DateOnly? endDate)
        {
            base.InnerQuery.AddArgument("endDate", endDate);
            return this;
        }

        public QueryRootCashManagementShopSummaryArgumentsBuilder StartDate(DateOnly? startDate)
        {
            base.InnerQuery.AddArgument("startDate", startDate);
            return this;
        }
    }
}