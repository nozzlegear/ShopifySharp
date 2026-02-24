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
    public sealed class QueryRootSubscriptionBillingCyclesArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingCycleConnection?, QueryRootSubscriptionBillingCyclesArgumentsBuilder>
    {
        protected override QueryRootSubscriptionBillingCyclesArgumentsBuilder Self => this;

        public QueryRootSubscriptionBillingCyclesArgumentsBuilder(IQuery<SubscriptionBillingCycleConnection?> query) : base(query)
        {
        }

        public QueryRootSubscriptionBillingCyclesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootSubscriptionBillingCyclesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootSubscriptionBillingCyclesArgumentsBuilder BillingCyclesDateRangeSelector(SubscriptionBillingCyclesDateRangeSelector? billingCyclesDateRangeSelector)
        {
            base.InnerQuery.AddArgument("billingCyclesDateRangeSelector", billingCyclesDateRangeSelector);
            return this;
        }

        public QueryRootSubscriptionBillingCyclesArgumentsBuilder BillingCyclesIndexRangeSelector(SubscriptionBillingCyclesIndexRangeSelector? billingCyclesIndexRangeSelector)
        {
            base.InnerQuery.AddArgument("billingCyclesIndexRangeSelector", billingCyclesIndexRangeSelector);
            return this;
        }

        public QueryRootSubscriptionBillingCyclesArgumentsBuilder ContractId(string? contractId)
        {
            base.InnerQuery.AddArgument("contractId", contractId);
            return this;
        }

        public QueryRootSubscriptionBillingCyclesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootSubscriptionBillingCyclesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootSubscriptionBillingCyclesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public QueryRootSubscriptionBillingCyclesArgumentsBuilder SortKey(SubscriptionBillingCyclesSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}