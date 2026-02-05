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