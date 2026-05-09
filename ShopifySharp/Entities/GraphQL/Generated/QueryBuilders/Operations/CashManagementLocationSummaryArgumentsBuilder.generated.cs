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
    public sealed class CashManagementLocationSummaryArgumentsBuilder : ArgumentsBuilderBase<CashManagementSummary, CashManagementLocationSummaryArgumentsBuilder>
    {
        protected override CashManagementLocationSummaryArgumentsBuilder Self => this;

        public CashManagementLocationSummaryArgumentsBuilder(IQuery<CashManagementSummary> query) : base(query)
        {
        }

        public CashManagementLocationSummaryArgumentsBuilder EndDate(DateOnly? endDate)
        {
            base.InnerQuery.AddArgument("endDate", endDate);
            return this;
        }

        public CashManagementLocationSummaryArgumentsBuilder LocationId(string? locationId)
        {
            base.InnerQuery.AddArgument("locationId", locationId);
            return this;
        }

        public CashManagementLocationSummaryArgumentsBuilder StartDate(DateOnly? startDate)
        {
            base.InnerQuery.AddArgument("startDate", startDate);
            return this;
        }
    }
}