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
    public sealed class SubscriptionBillingCycleEditedContractBillingCyclesArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingCycleConnection?, SubscriptionBillingCycleEditedContractBillingCyclesArgumentsBuilder>
    {
        protected override SubscriptionBillingCycleEditedContractBillingCyclesArgumentsBuilder Self => this;

        public SubscriptionBillingCycleEditedContractBillingCyclesArgumentsBuilder(IQuery<SubscriptionBillingCycleConnection?> query) : base(query)
        {
        }

        public SubscriptionBillingCycleEditedContractBillingCyclesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public SubscriptionBillingCycleEditedContractBillingCyclesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public SubscriptionBillingCycleEditedContractBillingCyclesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public SubscriptionBillingCycleEditedContractBillingCyclesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public SubscriptionBillingCycleEditedContractBillingCyclesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public SubscriptionBillingCycleEditedContractBillingCyclesArgumentsBuilder SortKey(SubscriptionBillingCyclesSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}