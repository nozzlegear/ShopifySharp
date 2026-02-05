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
    public sealed class SubscriptionBillingCycleSkipArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingCycleSkipPayload, SubscriptionBillingCycleSkipArgumentsBuilder>
    {
        protected override SubscriptionBillingCycleSkipArgumentsBuilder Self => this;

        public SubscriptionBillingCycleSkipArgumentsBuilder(IQuery<SubscriptionBillingCycleSkipPayload> query) : base(query)
        {
        }

        public SubscriptionBillingCycleSkipArgumentsBuilder BillingCycleInput(SubscriptionBillingCycleInput? billingCycleInput)
        {
            base.InnerQuery.AddArgument("billingCycleInput", billingCycleInput);
            return this;
        }
    }
}