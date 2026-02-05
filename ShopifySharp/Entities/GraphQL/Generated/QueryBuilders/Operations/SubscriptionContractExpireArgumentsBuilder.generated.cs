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
    public sealed class SubscriptionContractExpireArgumentsBuilder : ArgumentsBuilderBase<SubscriptionContractExpirePayload, SubscriptionContractExpireArgumentsBuilder>
    {
        protected override SubscriptionContractExpireArgumentsBuilder Self => this;

        public SubscriptionContractExpireArgumentsBuilder(IQuery<SubscriptionContractExpirePayload> query) : base(query)
        {
        }

        public SubscriptionContractExpireArgumentsBuilder SubscriptionContractId(string? subscriptionContractId)
        {
            base.InnerQuery.AddArgument("subscriptionContractId", subscriptionContractId);
            return this;
        }
    }
}