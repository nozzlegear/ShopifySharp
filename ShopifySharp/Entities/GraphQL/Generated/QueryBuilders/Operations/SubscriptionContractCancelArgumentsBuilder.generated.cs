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
    public sealed class SubscriptionContractCancelArgumentsBuilder : ArgumentsBuilderBase<SubscriptionContractCancelPayload, SubscriptionContractCancelArgumentsBuilder>
    {
        protected override SubscriptionContractCancelArgumentsBuilder Self => this;

        public SubscriptionContractCancelArgumentsBuilder(IQuery<SubscriptionContractCancelPayload> query) : base(query)
        {
        }

        public SubscriptionContractCancelArgumentsBuilder SubscriptionContractId(string? subscriptionContractId)
        {
            base.InnerQuery.AddArgument("subscriptionContractId", subscriptionContractId);
            return this;
        }
    }
}