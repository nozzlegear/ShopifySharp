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