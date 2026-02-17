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
    public sealed class SubscriptionBillingCycleEditsDeleteArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingCycleEditsDeletePayload, SubscriptionBillingCycleEditsDeleteArgumentsBuilder>
    {
        protected override SubscriptionBillingCycleEditsDeleteArgumentsBuilder Self => this;

        public SubscriptionBillingCycleEditsDeleteArgumentsBuilder(IQuery<SubscriptionBillingCycleEditsDeletePayload> query) : base(query)
        {
        }

        public SubscriptionBillingCycleEditsDeleteArgumentsBuilder ContractId(string? contractId)
        {
            base.InnerQuery.AddArgument("contractId", contractId);
            return this;
        }

        public SubscriptionBillingCycleEditsDeleteArgumentsBuilder TargetSelection(SubscriptionBillingCyclesTargetSelection? targetSelection)
        {
            base.InnerQuery.AddArgument("targetSelection", targetSelection);
            return this;
        }
    }
}