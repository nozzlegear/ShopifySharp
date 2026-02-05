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
    public sealed class SubscriptionBillingCyclesArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingCycleConnection, SubscriptionBillingCyclesArgumentsBuilder>
    {
        protected override SubscriptionBillingCyclesArgumentsBuilder Self => this;

        public SubscriptionBillingCyclesArgumentsBuilder(IQuery<SubscriptionBillingCycleConnection> query) : base(query)
        {
        }

        public SubscriptionBillingCyclesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public SubscriptionBillingCyclesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public SubscriptionBillingCyclesArgumentsBuilder BillingCyclesDateRangeSelector(SubscriptionBillingCyclesDateRangeSelector? billingCyclesDateRangeSelector)
        {
            base.InnerQuery.AddArgument("billingCyclesDateRangeSelector", billingCyclesDateRangeSelector);
            return this;
        }

        public SubscriptionBillingCyclesArgumentsBuilder BillingCyclesIndexRangeSelector(SubscriptionBillingCyclesIndexRangeSelector? billingCyclesIndexRangeSelector)
        {
            base.InnerQuery.AddArgument("billingCyclesIndexRangeSelector", billingCyclesIndexRangeSelector);
            return this;
        }

        public SubscriptionBillingCyclesArgumentsBuilder ContractId(string? contractId)
        {
            base.InnerQuery.AddArgument("contractId", contractId);
            return this;
        }

        public SubscriptionBillingCyclesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public SubscriptionBillingCyclesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public SubscriptionBillingCyclesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public SubscriptionBillingCyclesArgumentsBuilder SortKey(SubscriptionBillingCyclesSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}