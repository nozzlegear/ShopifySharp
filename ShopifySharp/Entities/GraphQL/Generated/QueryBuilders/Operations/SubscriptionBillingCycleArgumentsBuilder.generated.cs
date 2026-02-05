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
    public sealed class SubscriptionBillingCycleArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingCycle, SubscriptionBillingCycleArgumentsBuilder>
    {
        protected override SubscriptionBillingCycleArgumentsBuilder Self => this;

        public SubscriptionBillingCycleArgumentsBuilder(IQuery<SubscriptionBillingCycle> query) : base(query)
        {
        }

        public SubscriptionBillingCycleArgumentsBuilder BillingCycleInput(SubscriptionBillingCycleInput? billingCycleInput)
        {
            base.InnerQuery.AddArgument("billingCycleInput", billingCycleInput);
            return this;
        }
    }
}