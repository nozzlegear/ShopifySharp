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
    public sealed class SubscriptionContractPauseArgumentsBuilder : ArgumentsBuilderBase<SubscriptionContractPausePayload, SubscriptionContractPauseArgumentsBuilder>
    {
        protected override SubscriptionContractPauseArgumentsBuilder Self => this;

        public SubscriptionContractPauseArgumentsBuilder(IQuery<SubscriptionContractPausePayload> query) : base(query)
        {
        }

        public SubscriptionContractPauseArgumentsBuilder SubscriptionContractId(string? subscriptionContractId)
        {
            base.InnerQuery.AddArgument("subscriptionContractId", subscriptionContractId);
            return this;
        }
    }
}