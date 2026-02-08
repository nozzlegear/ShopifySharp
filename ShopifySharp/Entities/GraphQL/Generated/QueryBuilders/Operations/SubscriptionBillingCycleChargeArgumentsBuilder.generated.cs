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
    public sealed class SubscriptionBillingCycleChargeArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingCycleChargePayload, SubscriptionBillingCycleChargeArgumentsBuilder>
    {
        protected override SubscriptionBillingCycleChargeArgumentsBuilder Self => this;

        public SubscriptionBillingCycleChargeArgumentsBuilder(IQuery<SubscriptionBillingCycleChargePayload> query) : base(query)
        {
        }

        public SubscriptionBillingCycleChargeArgumentsBuilder BillingCycleSelector(SubscriptionBillingCycleSelector? billingCycleSelector)
        {
            base.InnerQuery.AddArgument("billingCycleSelector", billingCycleSelector);
            return this;
        }

        public SubscriptionBillingCycleChargeArgumentsBuilder InventoryPolicy(SubscriptionBillingAttemptInventoryPolicy? inventoryPolicy)
        {
            base.InnerQuery.AddArgument("inventoryPolicy", inventoryPolicy);
            return this;
        }

        public SubscriptionBillingCycleChargeArgumentsBuilder SubscriptionContractId(string? subscriptionContractId)
        {
            base.InnerQuery.AddArgument("subscriptionContractId", subscriptionContractId);
            return this;
        }
    }
}