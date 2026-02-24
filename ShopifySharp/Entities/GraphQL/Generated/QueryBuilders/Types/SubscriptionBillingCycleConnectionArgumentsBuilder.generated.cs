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
    public sealed class SubscriptionBillingCycleConnectionArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingCycleConnection, SubscriptionBillingCycleConnectionArgumentsBuilder>
    {
        protected override SubscriptionBillingCycleConnectionArgumentsBuilder Self => this;

        public SubscriptionBillingCycleConnectionArgumentsBuilder(IQuery<SubscriptionBillingCycleConnection> query) : base(query)
        {
        }

        public SubscriptionBillingCycleConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public SubscriptionBillingCycleConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public SubscriptionBillingCycleConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public SubscriptionBillingCycleConnectionArgumentsBuilder JobId(string? jobId)
        {
            base.InnerQuery.AddArgument("jobId", jobId);
            return this;
        }

        public SubscriptionBillingCycleConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public SubscriptionBillingCycleConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public SubscriptionBillingCycleConnectionArgumentsBuilder BillingCyclesDateRangeSelector(SubscriptionBillingCyclesDateRangeSelector? billingCyclesDateRangeSelector)
        {
            base.InnerQuery.AddArgument("billingCyclesDateRangeSelector", billingCyclesDateRangeSelector);
            return this;
        }

        public SubscriptionBillingCycleConnectionArgumentsBuilder BillingCyclesIndexRangeSelector(SubscriptionBillingCyclesIndexRangeSelector? billingCyclesIndexRangeSelector)
        {
            base.InnerQuery.AddArgument("billingCyclesIndexRangeSelector", billingCyclesIndexRangeSelector);
            return this;
        }

        public SubscriptionBillingCycleConnectionArgumentsBuilder ContractId(string? contractId)
        {
            base.InnerQuery.AddArgument("contractId", contractId);
            return this;
        }

        public SubscriptionBillingCycleConnectionArgumentsBuilder SortKey(SubscriptionBillingCyclesSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}