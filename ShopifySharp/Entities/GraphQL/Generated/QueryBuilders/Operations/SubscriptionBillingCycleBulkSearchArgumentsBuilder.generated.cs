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
    public sealed class SubscriptionBillingCycleBulkSearchArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingCycleBulkSearchPayload, SubscriptionBillingCycleBulkSearchArgumentsBuilder>
    {
        protected override SubscriptionBillingCycleBulkSearchArgumentsBuilder Self => this;

        public SubscriptionBillingCycleBulkSearchArgumentsBuilder(IQuery<SubscriptionBillingCycleBulkSearchPayload> query) : base(query)
        {
        }

        public SubscriptionBillingCycleBulkSearchArgumentsBuilder BillingAttemptExpectedDateRange(SubscriptionBillingCyclesDateRangeSelector? billingAttemptExpectedDateRange)
        {
            base.InnerQuery.AddArgument("billingAttemptExpectedDateRange", billingAttemptExpectedDateRange);
            return this;
        }

        public SubscriptionBillingCycleBulkSearchArgumentsBuilder Filters(SubscriptionBillingCycleBulkFilters? filters)
        {
            base.InnerQuery.AddArgument("filters", filters);
            return this;
        }
    }
}