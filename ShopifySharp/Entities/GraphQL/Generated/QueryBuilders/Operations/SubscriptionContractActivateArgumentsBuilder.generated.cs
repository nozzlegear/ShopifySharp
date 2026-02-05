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
    public sealed class SubscriptionContractActivateArgumentsBuilder : ArgumentsBuilderBase<SubscriptionContractActivatePayload, SubscriptionContractActivateArgumentsBuilder>
    {
        protected override SubscriptionContractActivateArgumentsBuilder Self => this;

        public SubscriptionContractActivateArgumentsBuilder(IQuery<SubscriptionContractActivatePayload> query) : base(query)
        {
        }

        public SubscriptionContractActivateArgumentsBuilder SubscriptionContractId(string? subscriptionContractId)
        {
            base.InnerQuery.AddArgument("subscriptionContractId", subscriptionContractId);
            return this;
        }
    }
}