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
    public sealed class SubscriptionDraftConcatenatedBillingCyclesArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingCycleConnection?, SubscriptionDraftConcatenatedBillingCyclesArgumentsBuilder>
    {
        protected override SubscriptionDraftConcatenatedBillingCyclesArgumentsBuilder Self => this;

        public SubscriptionDraftConcatenatedBillingCyclesArgumentsBuilder(IQuery<SubscriptionBillingCycleConnection?> query) : base(query)
        {
        }

        public SubscriptionDraftConcatenatedBillingCyclesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public SubscriptionDraftConcatenatedBillingCyclesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public SubscriptionDraftConcatenatedBillingCyclesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public SubscriptionDraftConcatenatedBillingCyclesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public SubscriptionDraftConcatenatedBillingCyclesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public SubscriptionDraftConcatenatedBillingCyclesArgumentsBuilder SortKey(SubscriptionBillingCyclesSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}