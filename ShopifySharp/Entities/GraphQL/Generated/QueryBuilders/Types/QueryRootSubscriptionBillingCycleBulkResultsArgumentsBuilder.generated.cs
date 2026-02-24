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
    public sealed class QueryRootSubscriptionBillingCycleBulkResultsArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingCycleConnection?, QueryRootSubscriptionBillingCycleBulkResultsArgumentsBuilder>
    {
        protected override QueryRootSubscriptionBillingCycleBulkResultsArgumentsBuilder Self => this;

        public QueryRootSubscriptionBillingCycleBulkResultsArgumentsBuilder(IQuery<SubscriptionBillingCycleConnection?> query) : base(query)
        {
        }

        public QueryRootSubscriptionBillingCycleBulkResultsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootSubscriptionBillingCycleBulkResultsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootSubscriptionBillingCycleBulkResultsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootSubscriptionBillingCycleBulkResultsArgumentsBuilder JobId(string? jobId)
        {
            base.InnerQuery.AddArgument("jobId", jobId);
            return this;
        }

        public QueryRootSubscriptionBillingCycleBulkResultsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootSubscriptionBillingCycleBulkResultsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}