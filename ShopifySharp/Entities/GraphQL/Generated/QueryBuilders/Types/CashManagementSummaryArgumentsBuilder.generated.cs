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
    public sealed class CashManagementSummaryArgumentsBuilder : ArgumentsBuilderBase<CashManagementSummary, CashManagementSummaryArgumentsBuilder>
    {
        protected override CashManagementSummaryArgumentsBuilder Self => this;

        public CashManagementSummaryArgumentsBuilder(IQuery<CashManagementSummary> query) : base(query)
        {
        }

        public CashManagementSummaryArgumentsBuilder EndDate(DateOnly? endDate)
        {
            base.InnerQuery.AddArgument("endDate", endDate);
            return this;
        }

        public CashManagementSummaryArgumentsBuilder LocationId(string? locationId)
        {
            base.InnerQuery.AddArgument("locationId", locationId);
            return this;
        }

        public CashManagementSummaryArgumentsBuilder StartDate(DateOnly? startDate)
        {
            base.InnerQuery.AddArgument("startDate", startDate);
            return this;
        }

        public CashManagementSummaryArgumentsBuilder CurrencyCode(CurrencyCode? currencyCode)
        {
            base.InnerQuery.AddArgument("currencyCode", currencyCode);
            return this;
        }
    }
}