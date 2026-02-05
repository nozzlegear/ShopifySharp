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
    public sealed class SubscriptionBillingAttemptCreateArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingAttemptCreatePayload, SubscriptionBillingAttemptCreateArgumentsBuilder>
    {
        protected override SubscriptionBillingAttemptCreateArgumentsBuilder Self => this;

        public SubscriptionBillingAttemptCreateArgumentsBuilder(IQuery<SubscriptionBillingAttemptCreatePayload> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptCreateArgumentsBuilder SubscriptionBillingAttemptInput(SubscriptionBillingAttemptInput? subscriptionBillingAttemptInput)
        {
            base.InnerQuery.AddArgument("subscriptionBillingAttemptInput", subscriptionBillingAttemptInput);
            return this;
        }

        public SubscriptionBillingAttemptCreateArgumentsBuilder SubscriptionContractId(string? subscriptionContractId)
        {
            base.InnerQuery.AddArgument("subscriptionContractId", subscriptionContractId);
            return this;
        }
    }
}