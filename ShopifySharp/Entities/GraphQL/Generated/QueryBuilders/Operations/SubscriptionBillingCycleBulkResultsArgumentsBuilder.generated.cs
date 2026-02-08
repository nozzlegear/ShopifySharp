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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class SubscriptionBillingCycleBulkResultsArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingCycleConnection, SubscriptionBillingCycleBulkResultsArgumentsBuilder>
    {
        protected override SubscriptionBillingCycleBulkResultsArgumentsBuilder Self => this;

        public SubscriptionBillingCycleBulkResultsArgumentsBuilder(IQuery<SubscriptionBillingCycleConnection> query) : base(query)
        {
        }

        public SubscriptionBillingCycleBulkResultsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public SubscriptionBillingCycleBulkResultsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public SubscriptionBillingCycleBulkResultsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public SubscriptionBillingCycleBulkResultsArgumentsBuilder JobId(string? jobId)
        {
            base.InnerQuery.AddArgument("jobId", jobId);
            return this;
        }

        public SubscriptionBillingCycleBulkResultsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public SubscriptionBillingCycleBulkResultsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}