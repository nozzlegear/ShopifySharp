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
    public sealed class SubscriptionBillingCycleScheduleEditArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingCycleScheduleEditPayload, SubscriptionBillingCycleScheduleEditArgumentsBuilder>
    {
        protected override SubscriptionBillingCycleScheduleEditArgumentsBuilder Self => this;

        public SubscriptionBillingCycleScheduleEditArgumentsBuilder(IQuery<SubscriptionBillingCycleScheduleEditPayload> query) : base(query)
        {
        }

        public SubscriptionBillingCycleScheduleEditArgumentsBuilder BillingCycleInput(SubscriptionBillingCycleInput? billingCycleInput)
        {
            base.InnerQuery.AddArgument("billingCycleInput", billingCycleInput);
            return this;
        }

        public SubscriptionBillingCycleScheduleEditArgumentsBuilder Input(SubscriptionBillingCycleScheduleEditInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}