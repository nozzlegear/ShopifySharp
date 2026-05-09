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
    public sealed class QueryRootCashManagementLocationSummaryArgumentsBuilder : ArgumentsBuilderBase<CashManagementSummary?, QueryRootCashManagementLocationSummaryArgumentsBuilder>
    {
        protected override QueryRootCashManagementLocationSummaryArgumentsBuilder Self => this;

        public QueryRootCashManagementLocationSummaryArgumentsBuilder(IQuery<CashManagementSummary?> query) : base(query)
        {
        }

        public QueryRootCashManagementLocationSummaryArgumentsBuilder EndDate(DateOnly? endDate)
        {
            base.InnerQuery.AddArgument("endDate", endDate);
            return this;
        }

        public QueryRootCashManagementLocationSummaryArgumentsBuilder LocationId(string? locationId)
        {
            base.InnerQuery.AddArgument("locationId", locationId);
            return this;
        }

        public QueryRootCashManagementLocationSummaryArgumentsBuilder StartDate(DateOnly? startDate)
        {
            base.InnerQuery.AddArgument("startDate", startDate);
            return this;
        }
    }
}