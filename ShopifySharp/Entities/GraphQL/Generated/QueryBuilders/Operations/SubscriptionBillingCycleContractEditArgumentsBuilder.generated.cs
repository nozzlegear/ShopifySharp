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
    public sealed class SubscriptionBillingCycleContractEditArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingCycleContractEditPayload, SubscriptionBillingCycleContractEditArgumentsBuilder>
    {
        protected override SubscriptionBillingCycleContractEditArgumentsBuilder Self => this;

        public SubscriptionBillingCycleContractEditArgumentsBuilder(IQuery<SubscriptionBillingCycleContractEditPayload> query) : base(query)
        {
        }

        public SubscriptionBillingCycleContractEditArgumentsBuilder BillingCycleInput(SubscriptionBillingCycleInput? billingCycleInput)
        {
            base.InnerQuery.AddArgument("billingCycleInput", billingCycleInput);
            return this;
        }
    }
}