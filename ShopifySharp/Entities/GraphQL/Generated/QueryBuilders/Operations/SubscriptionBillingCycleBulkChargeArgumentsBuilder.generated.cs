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
    public sealed class SubscriptionBillingCycleBulkChargeArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingCycleBulkChargePayload, SubscriptionBillingCycleBulkChargeArgumentsBuilder>
    {
        protected override SubscriptionBillingCycleBulkChargeArgumentsBuilder Self => this;

        public SubscriptionBillingCycleBulkChargeArgumentsBuilder(IQuery<SubscriptionBillingCycleBulkChargePayload> query) : base(query)
        {
        }

        public SubscriptionBillingCycleBulkChargeArgumentsBuilder BillingAttemptExpectedDateRange(SubscriptionBillingCyclesDateRangeSelector? billingAttemptExpectedDateRange)
        {
            base.InnerQuery.AddArgument("billingAttemptExpectedDateRange", billingAttemptExpectedDateRange);
            return this;
        }

        public SubscriptionBillingCycleBulkChargeArgumentsBuilder Filters(SubscriptionBillingCycleBulkFilters? filters)
        {
            base.InnerQuery.AddArgument("filters", filters);
            return this;
        }

        public SubscriptionBillingCycleBulkChargeArgumentsBuilder InventoryPolicy(SubscriptionBillingAttemptInventoryPolicy? inventoryPolicy)
        {
            base.InnerQuery.AddArgument("inventoryPolicy", inventoryPolicy);
            return this;
        }
    }
}