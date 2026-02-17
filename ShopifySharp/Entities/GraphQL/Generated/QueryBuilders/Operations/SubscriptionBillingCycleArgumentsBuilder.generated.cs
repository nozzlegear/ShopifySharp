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